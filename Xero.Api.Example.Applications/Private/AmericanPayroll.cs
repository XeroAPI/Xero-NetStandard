using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Private
{
    public class AmericanPayroll : Payroll.AmericanPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AmericanPayroll(bool includeRateLimiter = false) :
            base(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword),
                null,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}