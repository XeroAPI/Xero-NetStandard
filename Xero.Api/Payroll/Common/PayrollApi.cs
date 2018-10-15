using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Payroll.Common
{
    public abstract class PayrollApi : XeroApi
    {
        protected PayrollApi(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : this(auth, new XeroApiSettings(), user, rateLimiter)
        {
        }

        protected PayrollApi(IAuthenticator auth, IXeroApiSettings applicationSettings, IUser user = null, IRateLimiter rateLimiter = null)
            : this(applicationSettings.BaseUrl, auth, user, new Consumer(applicationSettings.ConsumerKey, applicationSettings.ConsumerSecret), rateLimiter)
        {
        }

        protected PayrollApi(string baseUrl, IAuthenticator auth, IUser user = null, IConsumer consumer = null, IRateLimiter rateLimiter = null)
            : base(baseUrl, auth, consumer, user, rateLimiter)
        {
        }
    }
}