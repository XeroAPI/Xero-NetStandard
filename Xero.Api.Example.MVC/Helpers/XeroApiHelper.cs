using System;
using Microsoft.Extensions.Configuration;
using Xero.Api.Core;
using Xero.Api.Example.Applications.Partner;
using Xero.Api.Example.Applications.Public;
using Xero.Api.Example.TokenStores;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.OAuth;
using Xero.Api.Serialization;

namespace Xero.Api.Example.MVC.Helpers
{
    public class ApplicationSettings
    {
        public string BaseApiUrl { get; set; }
        public Consumer Consumer { get; set; }
        public object Authenticator { get; set; }
    }

    public static class XeroApiHelper
    {
        private static ApplicationSettings _applicationSettings;

        static XeroApiHelper()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var apiSettings = config.GetSection("XeroApi");

            //Are you using a partner app?
            var isPartnerApp = bool.Parse(apiSettings["IsPartnerApp"]);

            //Base url for the api you are hitting - allows you to target your own mocked API
            var baseUrl = apiSettings["BaseUrl"];

            // Refer to README.md for details
            var callbackUrl = apiSettings["CallbackUrl"];

            // Consumer details for Application
            var consumerKey = apiSettings["ConsumerKey"];
            var consumerSecret = apiSettings["ConsumerSecret"];

            
            // Signing certificate details for Partner Applications
            var signingCertificatePath = apiSettings["SigningCertPath"];
            var signingCertificatePassword = apiSettings["SigningCertPassword"];
            
            // Set up some token stores to hold request and access tokens
            var accessTokenStore = new MemoryTokenStore();
            var requestTokenStore = new MemoryTokenStore();

            // Set the application settings with an authenticator relevant to your app type 
            if (isPartnerApp)
            {
                var partnerConsumer = new Consumer(consumerKey, consumerSecret);

                var partnerAuthenticator = new PartnerMvcAuthenticator(baseUrl, callbackUrl,
                        accessTokenStore, signingCertificatePath,
                        partnerConsumer, requestTokenStore, signingCertificatePassword);

                var partnerApplicationSettings = new ApplicationSettings
                {
                    BaseApiUrl = baseUrl,
                    Consumer = partnerConsumer,
                    Authenticator = partnerAuthenticator
                };

                _applicationSettings = partnerApplicationSettings;
            }
            else
            {
                var publicConsumer = new Consumer(consumerKey, consumerSecret);

                var publicAuthenticator = new PublicMvcAuthenticator(baseUrl, callbackUrl, accessTokenStore,
                    publicConsumer, requestTokenStore);

                var publicApplicationSettings = new ApplicationSettings
                {
                    BaseApiUrl = baseUrl,
                    Consumer = publicConsumer,
                    Authenticator = publicAuthenticator
                };

                _applicationSettings = publicApplicationSettings;
            }
        }

        public static ApiUser User()
        {
            return new ApiUser { Name = Environment.MachineName };
        }

        public static IConsumer Consumer()
        {
            return _applicationSettings.Consumer;
        }

        public static IMvcAuthenticator MvcAuthenticator()
        {
            return (IMvcAuthenticator)_applicationSettings.Authenticator;
        }

        public static IXeroCoreApi CoreApi()
        {
            if (_applicationSettings.Authenticator is IAuthenticator)
            {
                return new XeroCoreApi(_applicationSettings.BaseApiUrl, _applicationSettings.Authenticator as IAuthenticator,
                    _applicationSettings.Consumer, User(), new DefaultMapper(), new DefaultMapper());
            }

            return null;
        }
    }
}
