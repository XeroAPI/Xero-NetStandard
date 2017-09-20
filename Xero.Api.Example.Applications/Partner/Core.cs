using Xero.Api.Core;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Example.Applications.Partner
{
    public class Core : XeroCoreApi
    {
        private static readonly ApplicationSettings ApplicationSettings = new ApplicationSettings();

        public Core(ITokenStore store, IUser user, bool includeRateLimiter = false) :
            base(new PartnerAuthenticator(
                    ApplicationSettings.BaseUrl,
                    ApplicationSettings.CallbackUrl,
                    store,
                    ApplicationSettings.SigningCertificatePath,
                    ApplicationSettings.SigningCertificatePassword),
                user,
                includeRateLimiter ? new RateLimiter() : null)
        {
        }
    }
}
