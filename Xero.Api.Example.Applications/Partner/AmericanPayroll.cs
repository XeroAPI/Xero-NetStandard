using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Partner
{
    public class AmericanPayroll : Payroll.AmericanPayroll
    {
        private static readonly DefaultMapper Mapper = new DefaultMapper();
        private static readonly Settings ApplicationSettings = new Settings();

        public AmericanPayroll(ITokenStore store, IUser user, bool includeRateLimiter = false, string scope = null) :
            base(ApplicationSettings.BaseUrl,
                new PartnerAuthenticator(
                    ApplicationSettings.BaseUrl,
                    ApplicationSettings.CallbackUrl,
                    store,
                    ApplicationSettings.SigningCertificatePath,
                    ApplicationSettings.SigningCertificatePassword,
                    scope),
                new Consumer(
                    ApplicationSettings.Key,
                    ApplicationSettings.Secret),
                user,
                Mapper,
                Mapper,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}