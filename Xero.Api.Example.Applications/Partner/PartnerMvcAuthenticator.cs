using System;
using System.Security.Cryptography.X509Certificates;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Example.Applications.Partner
{
    public class PartnerMvcAuthenticator : PublicMvcAuthenticator
    {       
        private readonly X509Certificate2 _signingCertificate;

        private PartnerMvcAuthenticator(string baseUri, string callBackUri,
            ITokenStore store, IConsumer consumer, ITokenStore requestTokenStore)
            : base(baseUri, callBackUri, store, consumer, requestTokenStore)
        {            
        }

        public PartnerMvcAuthenticator(string baseUri, string callBackUri, 
            ITokenStore store, string signingCertificatePath, IConsumer consumer, ITokenStore requestTokenStore)
            : this(baseUri, callBackUri, store, signingCertificatePath, consumer, requestTokenStore, "")
        {
        }

        public PartnerMvcAuthenticator(string baseUri, string callBackUri, 
            ITokenStore store, string signingCertificatePath, 
            IConsumer consumer, ITokenStore requestTokenStore, string signingCertPassword)
            : this(baseUri, callBackUri, store, consumer, requestTokenStore)
        {
            _signingCertificate = new X509Certificate2(signingCertificatePath, signingCertPassword, X509KeyStorageFlags.MachineKeySet);
        }

        public PartnerMvcAuthenticator(string baseUri, string callBackUri, 
            ITokenStore store, X509Certificate2 signingCertificate,
            IConsumer consumer, ITokenStore requestTokenStore)
            : this(baseUri, callBackUri, store, consumer, requestTokenStore)
        {
            _signingCertificate = signingCertificate;
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
