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

            var apiSettings = builder.GetSection("XeroApi");

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
        public XeroApiSettings() : this("appsettings.json")
        {
        }

        public string BaseUrl { get; }

        public string CallbackUrl { get; }

        public string ConsumerKey { get; }

        public string ConsumerSecret { get; }

        public string SigningCertificatePath { get; }

        public string SigningCertificatePassword { get; }

        public XeroApiAppType AppType { get; }
    }
}
