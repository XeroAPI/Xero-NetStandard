using Xero.Api.Core;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Example.Applications.Public
{
    public class Core : XeroCoreApi
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();
        
        public Core(ITokenStore store, IUser user, bool includeRateLimiter = false) :
            base(new PublicAuthenticator(
                    ApplicationSettings.BaseUrl,
                    ApplicationSettings.CallbackUrl,                    
                    store),
                user,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}
