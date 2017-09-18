using System;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;

namespace Xero.Api.Example.Applications
{
    public abstract class TokenStoreAuthenticator : IAuthenticator
    {
        protected string BaseUri { get; set; }
        protected string CallBackUri { get; set; }
        protected ITokenStore Store { get; set; }

        private OAuthTokens _tokens;

        protected OAuthTokens Tokens 
        {
            get 
            {
                if (_tokens == null)
                {
                    _tokens = new OAuthTokens(BaseUri);      
                }
                return _tokens;
            } 
        }

        protected TokenStoreAuthenticator(string baseUri, string callBackUri, ITokenStore store)
        {
            CallBackUri = callBackUri;
            BaseUri = baseUri;
            Store = store;                      
        }

        public string GetSignature(IConsumer consumer, IUser user, Uri uri, string verb, IConsumer consumer1)
        {
            return GetAuthorization(GetToken(consumer, user), verb, uri.AbsolutePath, uri.Query);
        }

        public IToken GetToken(IConsumer consumer, IUser user)
        {
            if (!HasStore)
                return GetToken(consumer);

            var token = Store.Find(user.Name);

            if (token == null)
            {
                token = GetToken(consumer);
                token.UserId = user.Name;

                Store.Add(token);

                return token;
            }

            if (!token.HasExpired)
                return token;
            
            var newToken = RenewToken(token, consumer);
            newToken.UserId = user.Name;

            Store.Delete(token);
            Store.Add(newToken);

            return newToken;
        }

        public bool HasStore
        {
            get { return Store != null; }
        }

        public IUser User { get; set; }

        protected abstract string AuthorizeUser(IToken oauthToken);
        protected abstract string CreateSignature(IToken token, string verb, Uri uri, string verifier,
            bool renewToken = false, string callback = null);

        protected abstract IToken RenewToken(IToken sessionToken, IConsumer consumer);

        protected virtual IToken GetToken(IConsumer consumer)
        {
            var requestToken = GetRequestToken(consumer);
   
            var verifier = AuthorizeUser(requestToken);

            return Tokens.GetAccessToken(requestToken,
                GetAuthorization(requestToken, "POST", Tokens.AccessUri, null, verifier));
        }

        protected string GetAuthorizeUrl(IToken token, string scope = null)
        {
            return new UriBuilder(Tokens.AuthorizeUri)
            {
                Query = "oauth_token=" + token.TokenKey + "&scope=" + scope
            }.Uri.ToString();
        }

        protected IToken GetRequestToken(IConsumer consumer)
        {
            var token = new Token
            {
                ConsumerKey = consumer.ConsumerKey,
                ConsumerSecret = consumer.ConsumerSecret
            };
            
            var requestTokenOAuthHeader = GetAuthorization(token, "POST", Tokens.RequestUri, callback: CallBackUri);

            return Tokens.GetRequestToken(consumer, requestTokenOAuthHeader);
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
    }
}
