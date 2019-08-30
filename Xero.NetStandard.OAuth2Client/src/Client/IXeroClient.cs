
namespace Xero.NetStandard.OAuth2.Client
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Xero.NetStandard.OAuth2.Config;
    using Xero.NetStandard.OAuth2.Models;
    using Xero.NetStandard.OAuth2.Token;

    public interface IXeroClient
    {
        XeroConfiguration xeroConfiguration { get; set; }
        string BuildLoginUri();
        Task<IXeroToken> RequestAccessTokenAsync(string code);
        Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken);
        Task<IXeroToken> RequestXeroTokenAsync(string code);
        Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken);
        Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken);
    }
}