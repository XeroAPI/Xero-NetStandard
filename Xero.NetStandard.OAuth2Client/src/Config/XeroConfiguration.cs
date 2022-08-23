using System;

namespace Xero.NetStandard.OAuth2.Config
{
    public class XeroConfiguration
    {
        public string AppName { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public Uri CallbackUri { get; set; }
        public string Scope { get; set; }
        public string State { get; set; }
        public string XeroApiBaseUri { get; set; } = "https://api.xero.com";
        public string XeroLoginBaseUri { get; set; } = "https://login.xero.com";
        public string XeroIdentityBaseUri { get; set; } = "https://identity.xero.com";
    }
}