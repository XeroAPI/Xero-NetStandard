using System;
using Microsoft.Extensions.Configuration;

namespace Xero.Api
{
    public class XeroApiSettings : IXeroApiSettings
    {
        public XeroApiSettings(string path)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path)
                .Build();
                
            Load(builder);
        }
        public XeroApiSettings(IConfiguration config)
        {
            Load(config);
        }        
        public XeroApiSettings() : this("appsettings.json")
        {
        }
        private void Load(IConfiguration config)
        {
            var apiSettings = config.GetSection("XeroApi");

            BaseUrl = apiSettings["BaseUrl"];
            CallbackUrl = apiSettings["CallbackUrl"];
            ConsumerKey = apiSettings["ConsumerKey"];
            ConsumerSecret = apiSettings["ConsumerSecret"];
            SigningCertificatePath = apiSettings["SigningCertPath"];
            SigningCertificatePassword = apiSettings["SigningCertPassword"];

            if (!Enum.TryParse(apiSettings["AppType"], true, out XeroApiAppType appType))
            {
                throw new ArgumentOutOfRangeException(nameof(apiSettings), apiSettings["AppType"], "AppType did not match one of: private, public, partner");
            }

            AppType = appType;        
        }
        
        public string BaseUrl { private set; get; }

        public string CallbackUrl { private set; get; }

        public string ConsumerKey { private set; get; }

        public string ConsumerSecret { private set; get; }

        public string SigningCertificatePath { private set; get; }

        public string SigningCertificatePassword { private set; get; }

        public XeroApiAppType AppType { private set; get; }
    }
}
