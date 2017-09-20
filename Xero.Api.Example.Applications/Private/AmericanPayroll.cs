using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Example.Applications.Private
{
    public class AmericanPayroll : Payroll.AmericanPayroll
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public AmericanPayroll(bool includeRateLimiter = false) :
            this(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword), includeRateLimiter)
        {
        }

        public AmericanPayroll(IAuthenticator authenticator, bool includeRateLimiter = false)
            : base(authenticator, rateLimiter: includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}