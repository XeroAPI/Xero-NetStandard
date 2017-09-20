using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Partner
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AustralianPayroll(ITokenStore store, IUser user, bool includeRateLimiter = false, string scope = null) :
            base(new PartnerAuthenticator(
                    ApplicationSettings.BaseUrl,
                    ApplicationSettings.CallbackUrl,
                    store,
                    ApplicationSettings.SigningCertificatePath,
                    ApplicationSettings.SigningCertificatePassword,
                    scope),
                user,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}