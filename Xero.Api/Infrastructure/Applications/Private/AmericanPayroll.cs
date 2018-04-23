using Xero.Api.Infrastructure.Authenticators;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Infrastructure.Applications.Private
{
    public class AmericanPayroll : Payroll.AmericanPayroll
    {
        private static readonly XeroApiSettings ApplicationSettings = new XeroApiSettings();

        public AmericanPayroll(bool includeRateLimiter = false) :
            this(new PrivateAuthenticator(ApplicationSettings.SigningCertificatePath, ApplicationSettings.SigningCertificatePassword), includeRateLimiter)
        {
        }

        public AmericanPayroll(IAuthenticator authenticator, bool includeRateLimiter = false)
            : base(authenticator, rateLimiter: includeRateLimiter ? new RateLimiter.RateLimiter() : null)
        {
        }
    }
}