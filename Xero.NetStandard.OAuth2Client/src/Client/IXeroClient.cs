using System.Collections.Generic;
using System.Threading;
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
        Task<IXeroToken> RequestAccessTokenAsync(string code, CancellationToken cancellationToken = default);
        Task<IXeroToken> RequestAccessTokenPkceAsync(string code, string codeVerifier, CancellationToken cancellationToken = default);
        Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken, CancellationToken cancellationToken = default);
        Task<IXeroToken> RequestClientCredentialsTokenAsync(bool fetchTenants = true, CancellationToken cancellationToken = default);
        Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken, CancellationToken cancellationToken = default);
        Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken, CancellationToken cancellationToken = default);
        Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant, CancellationToken cancellationToken = default);
        Task RevokeAccessTokenAsync(IXeroToken xeroToken, CancellationToken cancellationToken = default);
    }
}