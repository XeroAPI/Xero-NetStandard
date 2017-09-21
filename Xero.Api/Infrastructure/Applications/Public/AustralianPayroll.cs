using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Public
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        public AustralianPayroll(PublicAuthenticatorBase authenticator, IUser user, bool includeRateLimiter = false)
            : base(authenticator, user, includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}