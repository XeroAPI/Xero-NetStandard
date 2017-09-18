using System;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Example.Applications.Public
{
    public class PublicAuthenticator : TokenStoreAuthenticator
    {
        private readonly string _scope;

        public PublicAuthenticator(string baseUri, string callBackUrl, ITokenStore store, string scope = null) 
            : base(baseUri, callBackUrl, store)
        {
            _scope = scope;
        }

        protected override string AuthorizeUser(IToken token)
        {
            var authorizeUrl = GetAuthorizeUrl(token, _scope);

            ProcessHelper.OpenBrowser(authorizeUrl);

            Console.WriteLine("Enter the PIN given on the web page");

            return Console.ReadLine();
        }

        protected override string CreateSignature(IToken token, string verb, Uri uri, string verifier,
            bool renewToken = false, string callback = null)
        {
            return new HmacSha1Signer().CreateSignature(token, uri, verb, verifier, callback);
        }

        protected override IToken RenewToken(IToken sessionToken, IConsumer consumer)
        {
            return GetToken(consumer);
        }
    }   
}