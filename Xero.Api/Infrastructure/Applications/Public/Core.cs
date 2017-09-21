using Xero.Api.Core;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Public
{
    public class Core : XeroCoreApi
    {
        public Core(PublicAuthenticatorBase authenticator, IUser user, bool includeRateLimiter = false)
            : base(authenticator, user, includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}
