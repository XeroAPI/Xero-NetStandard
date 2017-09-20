using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Public
{
    public class AmericanPayroll : Payroll.AmericanPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AmericanPayroll(ITokenStore store, IUser user, bool includeRateLimiter = false, string scope = null) :
            base(new PublicAuthenticator(
                    ApplicationSettings.BaseUrl,
                    ApplicationSettings.CallbackUrl,
                    store,
                    scope),
                user,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}