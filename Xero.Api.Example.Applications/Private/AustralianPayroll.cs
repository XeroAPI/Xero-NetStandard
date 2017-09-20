using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Private
{
    public class AustralianPayroll : Payroll.AustralianPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AustralianPayroll(bool includeRateLimiter = false) :
            base(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword),
                null,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}