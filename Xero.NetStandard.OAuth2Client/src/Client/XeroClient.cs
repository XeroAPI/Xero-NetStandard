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
        public XeroConfiguration xeroConfiguration { get; set; }
        private readonly RequestUrl xeroAuthorizeUri;
        private readonly IHttpClientFactory httpClientFactory;
        /// <summary>
        /// Builds a XeroLogin URL
        /// </summary>
        /// <returns>valid URI for login</returns>
        public string BuildLoginUri()
        {
            var url = xeroAuthorizeUri.CreateAuthorizeUrl(
                clientId: xeroConfiguration.ClientId,
                responseType: "code", //hardcoded authorisation code for now.
                redirectUri: xeroConfiguration.CallbackUri.AbsoluteUri,
                state: xeroConfiguration.State,
                scope: xeroConfiguration.Scope
            );
            return url;
        }
        /// <summary>
        /// Constructor, pass in IHttpFactory to generate the client
        /// </summary>
        /// <param name="XeroConfig"></param>
        /// <param name="httpClientFactory"></param>
        public XeroClient(XeroConfiguration XeroConfig, IHttpClientFactory httpClientFactory)
        {
            this.xeroConfiguration = XeroConfig;
            this.xeroAuthorizeUri = new RequestUrl("https://login.xero.com/identity/connect/authorize");
            this.httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));

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

            var client = httpClientFactory.CreateClient("Xero");
            var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = "https://identity.xero.com/connect/token",
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

            if (response.IsError) { throw new Exception(response.Error); }
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
                throw new ArgumentNullException("xeroToken");
            }
            var client = httpClientFactory.CreateClient("Xero");

            var response = await client.RequestRefreshTokenAsync(new RefreshTokenRequest
            {
                Address = "https://identity.xero.com/connect/token",
                ClientId = xeroConfiguration.ClientId,
                ClientSecret = xeroConfiguration.ClientSecret,
                RefreshToken = xeroToken.RefreshToken
            });
            if (response.IsError) { throw new Exception(response.Error); }
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
            var client = httpClientFactory.CreateClient("Xero");
            var response = await client.RequestAuthorizationCodeTokenAsync(new AuthorizationCodeTokenRequest
            {
                Address = "https://identity.xero.com/connect/token",
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

            if (response.IsError) { throw new Exception(response.Error); }
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
            var client = httpClientFactory.CreateClient("Xero");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", xeroToken.AccessToken);
            using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, "https://api.xero.com/connections"))
            {
                HttpResponseMessage result = await client.SendAsync(requestMessage);
                string json = await result.Content.ReadAsStringAsync();
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

        /// <summary>
        /// Delete the connection given the accesstoken and xero tenant id
        /// </summary>
        /// <param name="xeroToken"></param>
        /// <param name="xeroTenant"></param>
        /// <returns>List of Tenants attached to accesstoken</returns>
        public async Task DeleteConnectionAsync(IXeroToken xeroToken, Tenant xeroTenant)
        {
            var client = httpClientFactory.CreateClient("Xero");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", xeroToken.AccessToken);
            using (var requestMessage = new HttpRequestMessage(System.Net.Http.HttpMethod.Delete, "https://api.xero.com/connections" + "/" + xeroTenant.id))
            {
                HttpResponseMessage result = await client.SendAsync(requestMessage);
                string json = await result.Content.ReadAsStringAsync();
                if (result.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return;
                }
                else
                {
                    throw new HttpRequestException(await result.Content.ReadAsStringAsync());
                }
            }
        }
    }
}