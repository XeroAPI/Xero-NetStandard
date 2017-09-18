using System;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth.Signing;

namespace Xero.Api.Example.Applications.Public
{
    public class PublicMvcAuthenticator : TokenStoreAuthenticator, IMvcAuthenticator
    {
        private readonly IConsumer _consumer;
        private readonly ITokenStore _requestTokenStore;

        public PublicMvcAuthenticator(string baseUri, string callBackUrl,
            ITokenStore store, IConsumer consumer, ITokenStore requestTokenStore)
            : base(baseUri, callBackUrl, store)
        {
            _consumer = consumer;
            _requestTokenStore = requestTokenStore;
        }

        protected override string AuthorizeUser(IToken token)
        {
            throw new NotSupportedException();
        }

        protected override string CreateSignature(IToken token, string verb, Uri uri, string verifier,
            bool renewToken = false, string callback = null)
        {
            return new HmacSha1Signer().CreateSignature(token, uri, verb, verifier, callback);
        }

        protected override IToken RenewToken(IToken sessionToken, IConsumer consumer)
        {
            throw new RenewTokenException();
        }

        public string GetRequestTokenAuthorizeUrl(string userId)
        {
            var requestToken = GetRequestToken(_consumer);
            requestToken.UserId = userId;

            var existingToken = _requestTokenStore.Find(userId);
            if (existingToken != null)
                _requestTokenStore.Delete(requestToken);

            _requestTokenStore.Add(requestToken);

            return GetAuthorizeUrl(requestToken);
        }

        public IToken RetrieveAndStoreAccessToken(string userId, string tokenKey, string verfier, string organisationShortCode)
        {
            var existingAccessToken = Store.Find(userId);
            if (existingAccessToken != null)
            {
                if (!existingAccessToken.HasExpired)
                    return existingAccessToken;
                else
                    Store.Delete(existingAccessToken);
            }

            var requestToken = _requestTokenStore.Find(userId);
            if (requestToken == null)
                throw new ApplicationException("Failed to look up request token for user");

			//Delete the request token from the _requestTokenStore as the next few lines will render it useless for the future.
            _requestTokenStore.Delete(requestToken);

            if (requestToken.TokenKey != tokenKey)
                throw new ApplicationException("Request token key does not match");

            var accessToken = Tokens.GetAccessToken(requestToken,
                GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verfier));

            accessToken.UserId = userId;

            Store.Add(accessToken);

            return accessToken;
        }
    }   
}
