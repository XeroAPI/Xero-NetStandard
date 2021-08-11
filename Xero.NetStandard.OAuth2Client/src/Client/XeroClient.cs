using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using Xero.NetStandard.OAuth2.Models;
using IdentityModel.Client;
using Newtonsoft.Json;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.NetStandard.OAuth2.Client
{
    public class XeroClient : IXeroClient
    {
        public XeroConfiguration xeroConfiguration { get; set; }
        private readonly RequestUrl _xeroAuthorizeUri;
        private readonly Uri _xeroTokenUri;
        private readonly Uri _xeroTokenRevocationUri;
        private readonly Uri _xeroConnectionsUri;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor, pass in xeroConfig and httpClient to generate the XeroClient. Can be used in conjunction with AddHttpClient extension of ServiceProvider for dependency injection
        /// </summary>
        /// <param name="xeroConfig"></param>
        /// <param name="httpClient" description="optional"></param>
        /// <param name="baseAuthorizeUri" description="optional"></param>
        /// <param name="baseTokenUri" description="optional"></param>
        /// <param name="baseApiUri" description="optional"></param>
        public XeroClient(XeroConfiguration xeroConfig, HttpClient httpClient = null, Uri baseAuthorizeUri = null, Uri baseTokenUri = null, Uri baseApiUri = null)
        {
            xeroConfiguration = xeroConfig;

            _httpClient = httpClient ?? new HttpClient();

            var authorizeUri = new Uri("https://login.xero.com/identity/connect/authorize");
            var tokenUri = new Uri("https://identity.xero.com/connect/token");
            var tokenRevocationUri = new Uri("https://identity.xero.com/connect/revocation");
            var connectionsUri = new Uri("https://api.xero.com/connections");

            _xeroAuthorizeUri = baseAuthorizeUri != null 
                ? new RequestUrl(baseAuthorizeUri.AbsoluteUri + authorizeUri.AbsolutePath)
                : new RequestUrl(authorizeUri.ToString());

            _xeroTokenUri = baseTokenUri != null
                ? new Uri(baseTokenUri.GetLeftPart(UriPartial.Authority) + tokenUri.AbsolutePath)
                : new Uri(tokenUri.ToString());

            _xeroTokenRevocationUri = baseTokenUri != null
                ? new Uri(baseTokenUri.GetLeftPart(UriPartial.Authority) + tokenRevocationUri.AbsolutePath)
                : new Uri(tokenRevocationUri.ToString());

            _xeroConnectionsUri = baseApiUri != null
                ? new Uri(baseApiUri.GetLeftPart(UriPartial.Authority) + connectionsUri.AbsolutePath)
                : new Uri(connectionsUri.ToString());
        }

        /// <summary>
        /// Builds a XeroLogin URL for code flow
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUri()
        {
            return BuildLoginUri(xeroConfiguration.State);
        }

        /// <summary>
        /// Builds a XeroLogin URL for code flow, allows state to be passed in.
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUri(string state)
        {
            return BuildLoginUri(state, xeroConfiguration.Scope);
        }

        /// <summary>
        /// Builds a XeroLogin URL for code flow, allows state and scope to be passed in.
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUri(string state, string scope)
        {
            return BuildLoginUri(state, scope, xeroConfiguration.AcrValues);
        }

        /// <summary>
        /// Builds a XeroLogin URL for code flow, allows state, scope and acrValues to be passed in.
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUri(string state, string scope, string acrValues)
        { 
            var url = _xeroAuthorizeUri.CreateAuthorizeUrl(
                clientId: xeroConfiguration.ClientId,
                responseType: "code",
                redirectUri: xeroConfiguration.CallbackUri.AbsoluteUri,
                state: state,
                scope: scope,
                acrValues: acrValues
            );
            return url;
        }

        /// <summary>
        /// Builds a XeroLogin URL for PKCE flow with codeVerifier input
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUriPkce(string codeVerifier)
        {
            return BuildLoginUriPkce(codeVerifier, xeroConfiguration.State);
        }

        /// <summary>
        /// Builds a XeroLogin URL for PKCE flow with codeVerifier and state as inputs.
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUriPkce(string codeVerifier, string state)
        {
            return BuildLoginUriPkce(codeVerifier, state, xeroConfiguration.Scope);
        }

        /// <summary>
        /// Builds a XeroLogin URL for PKCE flow with codeVerifier, state and scope as inputs.
        /// </summary>
        /// <returns>A valid initial redirect URI for Xero OAuth 2.0 authorisation flow.</returns>
        public string BuildLoginUriPkce(string codeVerifier, string state, string scope)
        {
            string codeChallenge = null;

            /// Validating the code verifiier, read more at https://developer.xero.com/documentation/oauth2/pkce-flow
            if (codeVerifier.Length < 43 || codeVerifier.Length > 128) {
                throw new Exception("The code verifier must be between 43 and 128 characters.");
            } else {
                SHA256 sha256 = SHA256Managed.Create();

                var codeVerifierTextBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(codeVerifier);

                byte[] sha256Hash = sha256.ComputeHash(codeVerifierTextBytes);

                codeChallenge = System.Convert.ToBase64String(sha256Hash)
                    .Replace("=", "")
                    .Replace("/", "_")
                    .Replace("+", "-");
            }

            var url = _xeroAuthorizeUri.CreateAuthorizeUrl(
                clientId: xeroConfiguration.ClientId,
                responseType: "code",
                redirectUri: xeroConfiguration.CallbackUri.AbsoluteUri,
                state: state,
                scope: scope,
                codeChallenge: codeChallenge,
                codeChallengeMethod: "S256"
            );

            return url;
        }

        /// <summary>
        /// Refreshes your current token
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <returns></returns>
        public async Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken)
        {
            if (xeroToken == null)
            {
                throw new ArgumentNullException("xeroToken");
            }

            var response = await _httpClient.RequestRefreshTokenAsync(new RefreshTokenRequest
            {
                Address = _xeroTokenUri.AbsoluteUri,
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                RefreshToken = xeroToken.RefreshToken
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }

            xeroToken.AccessToken = response.AccessToken;
            xeroToken.RefreshToken = response.RefreshToken;
            xeroToken.IdToken = response.IdentityToken;
            xeroToken.ExpiresAtUtc = DateTime.UtcNow.AddSeconds(response.ExpiresIn);
            return xeroToken;

        }

        /// <summary>
        /// Requests a fully formed IXeroToken with list of tenants filled
        /// </summary>
        /// <returns></returns>
        public async Task<IXeroToken> RequestClientCredentialsTokenAsync(bool fetchTenants=true)
        {

            var response = await _httpClient.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                Address = "https://identity.xero.com/connect/token",
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                Scope = xeroConfiguration.Scope
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }

            var xeroToken = new XeroOAuth2Token()
            {
                AccessToken = response.AccessToken,
                ExpiresAtUtc = DateTime.UtcNow.AddSeconds(response.ExpiresIn)
            };
            if(fetchTenants){
                xeroToken.Tenants = await GetConnectionsAsync(xeroToken);
            }
            return xeroToken;

        }

        /// <summary>
        /// Requests a fully formed IXeroToken with list of tenants filled
        /// </summary>
        /// <param name="code">Code returned from callback</param>
        /// <returns></returns>
        public async Task<IXeroToken> RequestAccessTokenAsync(string code)
        {
            var response = await _httpClient.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = _xeroTokenUri.AbsoluteUri,
                GrantType = "code",
                Code = code,
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                RedirectUri = xeroConfiguration.CallbackUri.AbsoluteUri,
                Parameters =
                    {
                        { "scope", xeroConfiguration.Scope}
                    }
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }

            var xeroToken = new XeroOAuth2Token()
            {
                AccessToken = response.AccessToken,
                RefreshToken = response.RefreshToken,
                ExpiresAtUtc = DateTime.UtcNow.AddSeconds(response.ExpiresIn),
                IdToken = response.IdentityToken,
            };
            xeroToken.Tenants = await GetConnectionsAsync(xeroToken);
            return xeroToken;

        }

        /// <summary>
        /// Requests accesstoken and returns it inside the IXeroToken
        /// Check state before calling this method to prevent CRSF
        /// </summary>
        /// <param name="code">code from callback</param>
        /// <param name="codeVerifier">codeVerifier used for initial request</param>
        /// <param name="xeroToken"></param>
        /// <returns></returns>
        public async Task<IXeroToken> RequestAccessTokenPkceAsync(string code, string codeVerifier)
        {

            var response = await _httpClient.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = _xeroTokenUri.AbsoluteUri,
                GrantType = "code",
                Code = code,
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                RedirectUri = xeroConfiguration.CallbackUri.AbsoluteUri,
                Parameters =
                    {
                        { "scope", xeroConfiguration.Scope}
                    },
                CodeVerifier = codeVerifier
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }
            
            return new XeroOAuth2Token()
            {
                AccessToken = response.AccessToken,
                RefreshToken = response.RefreshToken,
                IdToken = response.IdentityToken,
                ExpiresAtUtc = DateTime.UtcNow.AddSeconds(response.ExpiresIn)
            };

        }

        /// <summary>
        /// Convenience method to refresh token for you if it is expired
        /// </summary>
        /// <param name="xeroToken">your current XeroToken</param>
        /// <returns></returns>
        public async Task<IXeroToken> GetCurrentValidTokenAsync(IXeroToken xeroToken)
        {
            if (DateTime.UtcNow > xeroToken.ExpiresAtUtc)
            {
                return await RefreshAccessTokenAsync(xeroToken);
            }

            return xeroToken;
        }
        /// <summary>
        /// Get's a list of Tokens given the accesstoken
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <returns>List of Tenants attached to accesstoken</returns>
        public async Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, _xeroConnectionsUri.AbsoluteUri))
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", xeroToken.AccessToken);

                var result = await _httpClient.SendAsync(requestMessage);
                var json = await result.Content.ReadAsStringAsync();
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    xeroToken.Tenants = JsonConvert.DeserializeObject<List<Tenant>>(json);
                    return xeroToken.Tenants;
                }

                throw new HttpRequestException(await result.Content.ReadAsStringAsync());
            }
        }

        /// <summary>
        /// Delete the connection given the accesstoken and xero tenant id
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <param name="xeroTenant"></param>
        /// <returns>List of Tenants attached to accesstoken</returns>
        public async Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Delete, _xeroConnectionsUri.AbsoluteUri + "/" + xeroTenant.id))
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", xeroToken.AccessToken);

                var result = await _httpClient.SendAsync(requestMessage);
                if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return;
                }

                throw new HttpRequestException(await result.Content.ReadAsStringAsync());
            }
        }

        /// <summary>
        /// Revokes the current token - immediate disconnect all orgs and stops the user authorisation
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <returns></returns>
        public async Task RevokeAccessTokenAsync(IXeroToken xeroToken)
        {
            if (xeroToken == null)
            {
                throw new ArgumentNullException("xeroToken");
            }

            var response = await _httpClient.RevokeTokenAsync(new TokenRevocationRequest {
                Address = _xeroTokenRevocationUri.AbsoluteUri,
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                Token = xeroToken.RefreshToken
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }

            return;
        }
    }
}