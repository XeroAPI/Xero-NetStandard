using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Infrastructure.Authenticators
{
    public class PrivateAuthenticator : IAuthenticator
    {
        private readonly X509Certificate2 _certificate;

        public X509Certificate Certificate => _certificate;

        public PrivateAuthenticator(string certificatePath)
            :this(certificatePath, "")
        {
        }

        public PrivateAuthenticator(string certificatePath, string certificatePassword = "")
        {
            _certificate = new X509Certificate2(certificatePath, certificatePassword, X509KeyStorageFlags.MachineKeySet);
        }

        public PrivateAuthenticator(X509Certificate2 certificate)
        {
            _certificate = certificate;
        }

        public Task AuthenticateAsync(HttpRequestMessage request, IConsumer consumer, IUser user)
        {
            var signature = GetSignature(request, consumer);

            request.Headers.Add("Authorization", signature);

            return Task.CompletedTask;
        }


        private string GetSignature(HttpRequestMessage request, IConsumer consumer)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret,
                TokenKey = consumer.ConsumerKey
            };

            return new RsaSha1Signer().CreateSignature(_certificate, token, request.RequestUri, request.Method.Method);
        }
    }
}