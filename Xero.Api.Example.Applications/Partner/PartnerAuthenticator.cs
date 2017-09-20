using System;
using System.Security.Cryptography.X509Certificates;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Example.Applications.Partner
{
    public class PartnerAuthenticator : TokenStoreAuthenticator
    {       
        private readonly X509Certificate2 _signingCertificate;
        private string _scope;

        private PartnerAuthenticator(string baseUri, string callBackUri, ITokenStore store, string scope = null)
            : base(baseUri, callBackUri, store)
        {
            _scope = scope;
        }

        public PartnerAuthenticator(string baseUri, string callBackUri, ITokenStore store, string signingCertificatePath, string scope = null)
            : this(baseUri, callBackUri, store, signingCertificatePath, "", scope)
        {
        }

        public PartnerAuthenticator(string baseUri, string callBackUri, ITokenStore store, string signingCertificatePath, string signingCertPassword, string scope = null)
            : this(baseUri, callBackUri, store, scope)
        {
            _signingCertificate = new X509Certificate2(signingCertificatePath, signingCertPassword, X509KeyStorageFlags.MachineKeySet);
        }

        public PartnerAuthenticator(string baseUri, string callBackUri, ITokenStore store, X509Certificate2 signingCertificate, string scope = null)
            : this(baseUri, callBackUri, store, scope)
        {
            _signingCertificate = signingCertificate;
        }

        protected override string AuthorizeUser(IToken token)
        {
            var authorizeUrl = GetAuthorizeUrl(token, _scope);

            ProcessHelper.OpenBrowser(authorizeUrl);

            Console.WriteLine("Enter the PIN given on the web page");

            return Console.ReadLine();
        }

        protected override string CreateSignature(IToken token, string verb, Uri uri,
            string verifier, bool renewToken = false, string callback = null)
        {
            return new RsaSha1Signer().CreateSignature(_signingCertificate, token, uri, verb, verifier, renewToken, callback);
        }

        protected override IToken RenewToken(IToken sessionToken, IConsumer consumer)
        {
            var authHeader = GetAuthorization(sessionToken, "POST", Tokens.AccessTokenEndpoint, null, null, true);

            return Tokens.GetAccessTokenAsync(sessionToken, authHeader).Result;
        }
    }
}
