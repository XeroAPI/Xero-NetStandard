using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Partner
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        public AustralianPayroll(PartnerAuthenticatorBase authenticator, IUser user, bool includeRateLimiter = false) :
            base(authenticator, user, includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}