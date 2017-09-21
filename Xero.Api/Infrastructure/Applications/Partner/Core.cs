using Xero.Api.Core;
using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Partner
{
    public class Core : XeroCoreApi
    {
        public Core(PartnerAuthenticatorBase authenticator, IUser user, bool includeRateLimiter = false) :
            base(authenticator, user, includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}
