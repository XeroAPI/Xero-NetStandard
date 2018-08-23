using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Infrastructure.Authenticators
{
    public abstract class TokenStoreAuthenticatorBase : IAuthenticator
    {
        protected readonly string BaseUri;
        protected readonly string CallBackUri;
        protected ITokenStoreAsync Store { get; set; }

        private OAuthTokens _tokens;

        protected OAuthTokens Tokens => _tokens ?? (_tokens = new OAuthTokens(BaseUri));
        public bool HasStore => Store != null;

        protected TokenStoreAuthenticatorBase(ITokenStoreAsync store, IXeroApiSettings applicationSettings)
        {
            Store = store;
            BaseUri = applicationSettings.BaseUrl;
            CallBackUri = applicationSettings.CallbackUrl;
        }

        protected abstract string AuthorizeUser(IToken oauthToken, string scope = null, bool redirectOnError = false);

        protected abstract string CreateSignature(IToken token, string verb, Uri uri, string verifier, bool renewToken = false, string callback = null);

        protected abstract Task<IToken> RenewTokenAsync(IToken sessionToken, IConsumer consumer);

        public async Task AuthenticateAsync(HttpRequestMessage request, IConsumer consumer, IUser user)
        {
            var token = await GetTokenAsync(consumer, user).ConfigureAwait(false);

            var authString = GetAuthorization(token, request.Method.Method, request.RequestUri.AbsolutePath, request.RequestUri.Query);

            request.Headers.Add("Authorization", authString);
        }

        protected async Task<IToken> GetTokenAsync(IConsumer consumer, IUser user)
        {
            if (!HasStore)
                return await GetTokenAsync(consumer).ConfigureAwait(false);

            var token = await Store.FindAsync(user.Identifier).ConfigureAwait(false);

            if (token == null)
            {
                token = await GetTokenAsync(consumer).ConfigureAwait(false);
                token.UserId = user.Identifier;

                await Store.AddAsync(token).ConfigureAwait(false);

                return token;
            }

            if (!token.HasExpired)
                return token;

            var newToken = await RenewTokenAsync(token, consumer).ConfigureAwait(false);
            newToken.UserId = user.Identifier;

            await Store.DeleteAsync(token).ConfigureAwait(false);
            await Store.AddAsync(newToken).ConfigureAwait(false);

            return newToken;
        }

        protected virtual async Task<IToken> GetTokenAsync(IConsumer consumer)
        {
            var requestToken = await GetRequestTokenAsync(consumer).ConfigureAwait(false);

            var verifier = AuthorizeUser(requestToken);

            return await Tokens.GetAccessTokenAsync(requestToken, GetAuthorization(requestToken, "POST", Tokens.AccessTokenEndpoint, null, verifier)).ConfigureAwait(false);
        }

        protected Task<IToken> GetRequestTokenAsync(IConsumer consumer)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret
            };

            var requestTokenOAuthHeader = GetAuthorization(token, "POST", Tokens.RequestTokenEndpoint, callback: CallBackUri);

            return Tokens.GetRequestTokenAsync(consumer, requestTokenOAuthHeader);
        }

        protected string GetAuthorization(IToken token, string verb, string endpoint, string query = null,
            string verifier = null, bool renewToken = false, string callback = null)
        {
            var uri = new UriBuilder(BaseUri)
            {
                Path = endpoint
            };

            if (!string.IsNullOrWhiteSpace(query))
            {
                uri.Query = query.TrimStart('?');
            }

            return CreateSignature(token, verb, uri.Uri, verifier, renewToken, callback);
        }

        protected string GetAuthorizeUrl(IToken token, string scope = null, bool redirectOnError = false)
        {
            return new UriBuilder(BaseUri)
            {
                Path = Tokens.AuthoriseEndpoint,
                Query = $"oauth_token={token.TokenKey}&scope={scope}&redirectOnError={redirectOnError}"
            }.Uri.ToString();
        }
    }
}
