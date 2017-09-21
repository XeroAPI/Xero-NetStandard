using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.Model;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Serialization;

namespace Xero.Api.Infrastructure.Http
{
    // This makes the calls to the web as text and asks the object mappers to convert to and from objects to text.
    // This knows nothing about the types being passed to and fro. (Except for the constraint in the generic type)
    public class XeroHttpClient
    {
        static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(5.5);

        internal readonly IJsonObjectMapper JsonMapper = new DefaultMapper();
        internal readonly IXmlObjectMapper XmlMapper = new DefaultMapper();
        internal static HttpClient HttpClient;

        private readonly Uri _baseUri;
        private readonly IAuthenticator _auth;
        private readonly IConsumer _consumer;
        private readonly IUser _user;
        private readonly IRateLimiter _rateLimiter;

        public XeroHttpClient(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IRateLimiter rateLimiter)
        {
            _baseUri = new Uri(baseUri);
            _auth = auth;
            _consumer = consumer;
            _user = user;
            _rateLimiter = rateLimiter;

            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate

            };

            HttpClient = new HttpClient(handler)
            {
                Timeout = DefaultTimeout
            };
        }

        public string UserAgent { get; set; }

        public async Task<IEnumerable<TResult>> GetAsync<TResult, TResponse>(string endPoint, NameValueCollection parameters = null, string where = "", string order = "", DateTime? modifiedSince = null)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(where, order, parameters, true);

            var request = CreateRequest(endPoint, HttpMethod.Get, modifiedSince, query: queryString);

            var response = await SendRequestAsync(request);

            return await ReadAsync<TResult, TResponse>(response);
        }

        internal async Task<IEnumerable<TResult>> PostAsync<TResult, TResponse>(string endpoint, byte[] data, string mimeType, NameValueCollection parameters = null)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, parameters, true);

            HttpContent content = new ByteArrayContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue(mimeType);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            var response = await SendRequestAsync(request);

            return await ReadAsync<TResult, TResponse>(response);
        }

        public async Task<IEnumerable<TResult>> PostAsync<TResult, TResponse>(string endpoint, object data, NameValueCollection parameters = null)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, parameters, true);

            HttpContent content = new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            var response = await SendRequestAsync(request);

            return await ReadAsync<TResult, TResponse>(response);
        }

        public async Task<IEnumerable<TResult>> PutAsync<TResult, TResponse>(string endpoint, object data, NameValueCollection parameters = null)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, parameters, true);

            HttpContent content = new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Put, content: content, query: queryString);

            var response = await SendRequestAsync(request);

            return await ReadAsync<TResult, TResponse>(response);
        }

        public async Task<IEnumerable<TResult>> DeleteAsync<TResult, TResponse>(string endpoint)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var request = CreateRequest(endpoint, HttpMethod.Delete);

            var response = await SendRequestAsync(request);

            return await ReadAsync<TResult, TResponse>(response);
        }

        internal async Task<HttpResponseMessage> GetAsync(string endpoint)
        {
            return await GetAsync(endpoint, null);
        }

        internal async Task<HttpResponseMessage> GetAsync(string endpoint, string query)
        {
            var request = CreateRequest(endpoint, HttpMethod.Get, query: query);

            return await SendRequestAsync(request);
        }

        internal async Task<HttpResponseMessage> GetRawAsync(string endpoint, string mimetype)
        {
            var request = CreateRequest(endpoint, HttpMethod.Get, accept: mimetype);

            return await SendRequestAsync(request);
        }

        internal async Task<HttpResponseMessage> PutAsync(string endpoint, object data, bool json = false, NameValueCollection parameters = null)
        {
            var queryString = CreateQueryString(null, null, parameters, true);

            HttpContent content = json
                ? new StringContent(JsonMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationJson)
                : new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Put, content: content, query: queryString);

            return await SendRequestAsync(request);
        }

        internal async Task<HttpResponseMessage> PostAsync(string endpoint, object data, bool json = false, NameValueCollection parameters = null)
        {
            var queryString = CreateQueryString(null, null, parameters, true);

            HttpContent content = json
                ? new StringContent(JsonMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationJson)
                : new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            return await SendRequestAsync(request);
        }

        internal async Task<HttpResponseMessage> DeleteAsync(string endpoint)
        {
            var request = CreateRequest(endpoint, HttpMethod.Delete);

            return await SendRequestAsync(request);
        }

        public async Task<HttpResponseMessage> PostMultipartFormAsync(string endpoint, string contentType, string name, string filename, byte[] payload)
        {
            var request = CreateRequest(endpoint, HttpMethod.Post);

            request.Content = CreateMultipartData(payload, name, filename);

            return await SendRequestAsync(request);
        }

        private HttpRequestMessage CreateRequest(string endPoint, HttpMethod method, DateTime? modifiedSince = null, string accept = "application/json", HttpContent content = null, string query = null)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                endPoint = string.Format("{0}?{1}", endPoint, query);
            }

            var uri = new Uri(_baseUri, endPoint);

            var request = new HttpRequestMessage(method, uri)
            {
                Content = content
            };

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

            if (modifiedSince.HasValue)
            {
                request.Headers.IfModifiedSince = modifiedSince;
            }

            _auth?.Authenticate(request, _consumer, _user);

            var escapedUserAgent = Uri.EscapeDataString(!string.IsNullOrWhiteSpace(UserAgent) ? UserAgent : "Xero Api wrapper - " + _consumer.ConsumerKey);

            request.Headers.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue(escapedUserAgent)));

            return request;
        }

        private async Task<HttpResponseMessage> SendRequestAsync(HttpRequestMessage request)
        {
            if (_rateLimiter != null)
                _rateLimiter.WaitUntilLimit();

            return await HttpClient.SendAsync(request);
        }

        private string CreateQueryString(string where, string order, NameValueCollection paramters, bool encoded)
        {
            var generator = new QueryGenerator(where, order, paramters);

            return encoded ? generator.UrlEncodedQueryString : generator.QueryString;
        }

        private MultipartFormDataContent CreateMultipartData(byte[] bytes, string name, string filename)
        {
            var content = new MultipartFormDataContent(); 
            content.Add(new ByteArrayContent(bytes), name, filename);

            return content;
        }

        internal async Task<IEnumerable<TResult>> ReadAsync<TResult, TResponse>(HttpResponseMessage response)
            where TResponse : IXeroResponse<TResult>, new()
        {
            // this is the 'happy path'
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonMapper.From<TResponse>(content).Values;
            }

            await HandleErrorsAsync(response);

            return null;
        }

        internal async Task HandleErrorsAsync(HttpResponseMessage response)
        {
            var body = await response.Content.ReadAsStringAsync();

            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                var data = JsonMapper.From<ApiException>(body);

                if (data.Elements != null && data.Elements.Any())
                {
                    throw new ValidationException(data);
                }

                //CHeck for inline errors
                var jsonObject = JObject.Parse(body);
                var inlineValidationErrors = jsonObject.SelectTokens("$..ValidationErrors..Message").Select(p => new ValidationError { Message = p.ToString() }).ToList();

                if (inlineValidationErrors.Any())
                {
                    data.Elements = new List<DataContractBase> { new DataContractBase { ValidationErrors = inlineValidationErrors } };
                    throw new ValidationException(data);
                }

                throw new BadRequestException(data);
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException(body);
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new NotFoundException(body);
            }

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new XeroApiException(response.StatusCode, body);
            }

            if (response.StatusCode == HttpStatusCode.ServiceUnavailable)
            {
                if (body.Contains("oauth_problem"))
                {
                    throw new RateExceededException(body);
                }

                throw new NotAvailableException(body);
            }

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                return;
            }


            throw new XeroApiException(response.StatusCode, body);
        }
    }
}
