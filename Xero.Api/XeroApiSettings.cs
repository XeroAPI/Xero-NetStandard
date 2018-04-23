using System;
using Microsoft.Extensions.Configuration;

namespace Xero.Api
{
    public class XeroApiSettings : IXeroApiSettings
    {
        public IConfigurationSection ApiSettings { get; set; }

        public XeroApiSettings(string path)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path)
                .Build();

            ApiSettings = builder.GetSection("XeroApi");
        }
        public XeroApiSettings() : this("appsettings.json")
        {
        }

        public string BaseUrl => ApiSettings["BaseUrl"];

        public string CallbackUrl => ApiSettings["CallbackUrl"];

        public string ConsumerKey => ApiSettings["ConsumerKey"];

        public string ConsumerSecret => ApiSettings["ConsumerSecret"];

        public string SigningCertificatePath => ApiSettings["SigningCertPath"];

        public string SigningCertificatePassword => ApiSettings["SigningCertPassword"];

        public bool IsPartnerApp
        {
            get
            {
                bool isPartnerApp = false;
                bool.TryParse(ApiSettings["IsPartnerApp"], out isPartnerApp);
                return isPartnerApp;
            }
        }
    }
}
