using System;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Models;
using IdentityModel.Client;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Xero.NetStandard.OAuth2.Config;
using Xero.NetStandard.OAuth2.Token;

namespace Xero.NetStandard.OAuth2.Client
{
    public class XeroClient : IXeroClient
    {
        const string CodeGrantType = "code";
        const string HttpClientName = "Xero";
        const string BearerScheme = "Bearer";
        const string AuthorizeUrl = "https://login.xero.com/identity/connect/authorize";
        const string IdentityTokenUrl = "https://identity.xero.com/connect/token";
        const string ConnectionsUrl = "https://api.xero.com/connections";

        private readonly RequestUrl _xeroAuthorizeUri;
        private readonly IHttpClientFactory _httpClientFactory;

        /// <summary>
        /// Constructor, pass in IHttpFactory to generate the client
        /// </summary>
        /// <param name="xeroConfiguration"></param>
        /// <param name="httpClientFactory"></param>
        public XeroClient(XeroConfiguration xeroConfiguration, IHttpClientFactory httpClientFactory)
        {
            XeroConfiguration = xeroConfiguration;

            _xeroAuthorizeUri = new RequestUrl(AuthorizeUrl);
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public XeroConfiguration XeroConfiguration { get; set; }

        /// <summary>
        /// Builds a XeroLogin URL
        /// </summary>
        /// <returns>valid URI for login</returns>
        public string BuildLoginUri()
        {
            var url = _xeroAuthorizeUri.CreateAuthorizeUrl(
                clientId: XeroConfiguration.ClientId,
                responseType: CodeGrantType, //hardcoded authorisation code for now.
                redirectUri: XeroConfiguration.CallbackUri.AbsoluteUri,
                state: XeroConfiguration.State,
                scope: XeroConfiguration.Scope
            );

            return url;
        }

        /// <summary>
        /// Requests accesstoken and returns it inside the IXeroToken
        /// Check state before calling this method to prevent CRSF
        /// </summary>
        /// <param name="code">code from callback</param>
        /// <param name="xeroToken"></param>
        /// <returns></returns>
        public async Task<IXeroToken> RequestAccessTokenAsync(string code)
        {
            var client = _httpClientFactory.CreateClient(HttpClientName);
            
            var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = IdentityTokenUrl,
                GrantType = CodeGrantType,
                Code = code,
                ClientId = XeroConfiguration.ClientId,
                ClientSecret = XeroConfiguration.ClientSecret,
                RedirectUri = XeroConfiguration.CallbackUri.AbsoluteUri,
                Parameters =
                    {
                        { "scope", XeroConfiguration.Scope}
                    }
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
        /// Refreshes your current token
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <returns></returns>
        public async Task<IXeroToken> RefreshAccessTokenAsync(IXeroToken xeroToken)
        {
            if (xeroToken == null)
            {
                throw new ArgumentNullException(nameof(xeroToken));
            }

            var client = _httpClientFactory.CreateClient(HttpClientName);

            var response = await client.RequestRefreshTokenAsync(new RefreshTokenRequest
            {
                Address = IdentityTokenUrl,
                ClientId = XeroConfiguration.ClientId,
                ClientSecret = XeroConfiguration.ClientSecret,
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
        /// <param name="code">Code returned from callback</param>
        /// <param name="xeroToken">IXeroToken to be returned</param>
        /// <returns></returns>
        public async Task<IXeroToken> RequestXeroTokenAsync(string code)
        {
            var client = _httpClientFactory.CreateClient(HttpClientName);
            var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = IdentityTokenUrl,
                GrantType = CodeGrantType,
                Code = code,
                ClientId = XeroConfiguration.ClientId,
                ClientSecret = XeroConfiguration.ClientSecret,
                RedirectUri = XeroConfiguration.CallbackUri.AbsoluteUri,
                Parameters =
                    {
                        { "scope", XeroConfiguration.Scope}
                    }
            });

            if (response.IsError)
            {
                throw new Exception(response.Error);
            }
            else
            {
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
            else
            {
                return xeroToken;
            }
        }

        /// <summary>
        /// Get's a list of Tokens given the accesstoken
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <returns>List of Tenants attached to accesstoken</returns>
        public async Task<List<Tenant>> GetConnectionsAsync(IXeroToken xeroToken)
        {
            var client = _httpClientFactory.CreateClient(HttpClientName);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(BearerScheme, xeroToken.AccessToken);
            
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, ConnectionsUrl))
            {
                var result = await client.SendAsync(requestMessage);
                var json = await result.Content.ReadAsStringAsync();
               
                if (result.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    xeroToken.Tenants = JsonConvert.DeserializeObject<List<Tenant>>(json);
                    return xeroToken.Tenants;
                }
                else
                {
                    throw new HttpRequestException(await result.Content.ReadAsStringAsync());
                }
            }
        }
    }
}