using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Models;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.NetStandard.OAuth2.Client
{
    public interface IXeroClient
    {
        XeroConfiguration xeroConfiguration { get; set; }
        string BuildLoginUri();
        string BuildLoginUri(string state);
        string BuildLoginUri(string state, string scope);
        string BuildLoginUriPkce(string codeVerifier);
        string BuildLoginUriPkce(string codeVerifier, string state);
        string BuildLoginUriPkce(string codeVerifier, string state, string scope);
        Task<IXeroToken> RequestAccessTokenAsync(string code);
        Task<IXeroToken> RequestAccessTokenPkceAsync(string code, string codeVerifier);
        Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken);
        Task<IXeroToken> RequestClientCredentialsTokenAsync();
        Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken);
        Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken);
        Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant);
        Task RevokeAccessTokenAsync(IXeroToken xeroToken);
    }
}