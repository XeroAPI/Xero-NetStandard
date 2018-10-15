using System;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.MVC.Authenticators
{
    public class PartnerMvcAuthenticator : PartnerAuthenticatorBase, IMvcAuthenticator
    {
        private readonly Consumer _consumer;
        private readonly ITokenStoreAsync _requestTokenStore;

        public PartnerMvcAuthenticator(ITokenStoreAsync requestTokenStore, ITokenStoreAsync accessTokenStore)
            : this(requestTokenStore, accessTokenStore, new XeroApiSettings())
        {
        }

        public PartnerMvcAuthenticator(ITokenStoreAsync requestTokenStore, ITokenStoreAsync accessTokenStore, IXeroApiSettings xeroApiSettings)
            : base(accessTokenStore, xeroApiSettings)
        {
            _consumer = new Consumer(xeroApiSettings.ConsumerKey, xeroApiSettings.ConsumerSecret);
            _requestTokenStore = requestTokenStore;
        }

        protected override string AuthorizeUser(IToken oauthToken, string scope = null, bool redirectOnError = false)
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetRequestTokenAuthorizeUrlAsync(string userId)
        {
            var requestToken = await GetRequestTokenAsync(_consumer);
            requestToken.UserId = userId;

            var existingToken = await _requestTokenStore.FindAsync(userId);
            if (existingToken != null)
                await _requestTokenStore.DeleteAsync(requestToken);

            await _requestTokenStore.AddAsync(requestToken);

            return GetAuthorizeUrl(requestToken);
        }

        public async Task<IToken> RetrieveAndStoreAccessTokenAsync(string userId, string tokenKey, string verifier)
        {
            var existingAccessToken = await Store.FindAsync(userId);
            if (existingAccessToken != null)
            {
                if (!existingAccessToken.HasExpired)
                    return existingAccessToken;
                else
                    await Store.DeleteAsync(existingAccessToken);
            }

            var requestToken = await _requestTokenStore.FindAsync(userId);
            if (requestToken == null)
                throw new ApplicationException("Failed to look up request token for user");

            //Delete the request token from the _requestTokenStore as the next few lines will render it useless for the future.
            await _requestTokenStore.DeleteAsync(requestToken);

            if (requestToken.TokenKey != tokenKey)
                throw new ApplicationException("Request token key does not match");

            var accessToken = await Tokens.GetAccessTokenAsync(requestToken, GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verifier));

            accessToken.UserId = userId;

            await Store.AddAsync(accessToken);

            return accessToken;
        }
    }
}
