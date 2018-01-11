using System;
using Microsoft.Extensions.Configuration;

namespace Xero.Api
{
    public class ApplicationSettings
    {
        public IConfigurationSection ApiSettings { get; set; }

        public ApplicationSettings(string path)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(path)
                .Build();

            ApiSettings = builder.GetSection("XeroApi");
        }
        public ApplicationSettings() : this("appsettings.json")
        {
        }

        public string BaseUrl => ApiSettings["BaseUrl"];

        public string CallbackUrl => ApiSettings["CallbackUrl"];

        public string Key => ApiSettings["ConsumerKey"];

        public string Secret => ApiSettings["ConsumerSecret"];

        public string SigningCertificatePath => ApiSettings["SigningCertPath"];

        public string SigningCertificatePassword => ApiSettings["SigningCertPassword"];
        public bool IsPartnerApp => Convert.ToBoolean(ApiSettings["IsPartnerApp"]);


    }
}
