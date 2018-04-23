using System;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.MVC.Authenticators
{
    public class PublicMvcAuthenticator : PublicAuthenticatorBase, IMvcAuthenticator
    {
        private readonly IConsumer _consumer;
        private readonly ITokenStore _requestTokenStore;

        public PublicMvcAuthenticator(ITokenStore requestTokenStore, ITokenStore accessTokenStore, IXeroApiSettings xeroApiSettings)
            : base(accessTokenStore, xeroApiSettings)
        {
            _consumer = new Consumer(ApplicationSettings.ConsumerKey, ApplicationSettings.ConsumerSecret);
            _requestTokenStore = requestTokenStore;
        }

        public PublicMvcAuthenticator(ITokenStore requestTokenStore, ITokenStore accessTokenStore)
            : base(accessTokenStore, new XeroApiSettings())
        {
            _consumer = new Consumer(ApplicationSettings.ConsumerKey, ApplicationSettings.ConsumerSecret);
            _requestTokenStore = requestTokenStore;
        }

        protected override string AuthorizeUser(IToken token, string scope = null, bool redirectOnError = false)
        {
            throw new NotSupportedException();
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

        public IToken RetrieveAndStoreAccessToken(string userId, string tokenKey, string verfier)
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

            var accessToken = Tokens.GetAccessTokenAsync(requestToken, GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verfier)).Result;

            accessToken.UserId = userId;

            Store.Add(accessToken);

            return accessToken;
        }
    }   
}
