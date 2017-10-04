using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Common
{
    // It is used to plug together the the components which are used for authentication and serialization.
    public abstract class XeroApi
    {
        public string BaseUri { get; protected set; }

        protected XeroHttpClient Client { get; private set; }

        protected XeroApi(string baseUrl, IAuthenticator auth, IConsumer consumer, IUser user, IRateLimiter rateLimiter)
        {
            BaseUri = baseUrl;

            Client = new XeroHttpClient(baseUrl, auth, consumer, user, rateLimiter);
        }   
    }
}