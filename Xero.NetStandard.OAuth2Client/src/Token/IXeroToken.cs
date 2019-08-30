using System;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Models;

namespace Xero.NetStandard.OAuth2.Token
{
    public interface IXeroToken
    {
        List<Tenant> Tenants { get; set; }
        string AccessToken { get; set; }
        string RefreshToken { get; set; }
        string IdToken { get; set; }
        DateTime ExpiresAtUtc { get; set; }
    }
}
