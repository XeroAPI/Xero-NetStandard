using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json.Linq;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Exceptions;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.Model;
using Xero.Api.Infrastructure.RateLimiter;

namespace Xero.Api.Infrastructure.Http
{
    // This makes the calls to the web as text and asks the object mappers to convert to and from objects to text.
    // This knows nothing about the types being passed to and fro. (Except for the constraint in the generic type)
    public class XeroHttpClient
    {
        static readonly TimeSpan DefaultTimeout = TimeSpan.FromMinutes(5.5);

        internal readonly IJsonObjectMapper JsonMapper;
        internal readonly IXmlObjectMapper XmlMapper;
        internal static System.Net.Http.HttpClient HttpClient;

        private IAuthenticator _auth;
        private IConsumer _consumer;
        private IUser _user;
        private IRateLimiter _rateLimiter;

        private XeroHttpClient(IJsonObjectMapper jsonMapper, IXmlObjectMapper xmlMapper)
        {
            JsonMapper = jsonMapper;
            XmlMapper = xmlMapper;
        }

        public XeroHttpClient(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user,
            IJsonObjectMapper jsonMapper, IXmlObjectMapper xmlMapper)
            : this(baseUri, auth, consumer, user, jsonMapper, xmlMapper, null)
        {
        }

        public XeroHttpClient(string baseUri, IAuthenticator auth, IConsumer consumer, IUser user, IJsonObjectMapper jsonMapper, IXmlObjectMapper xmlMapper, IRateLimiter rateLimiter)
            : this(jsonMapper, xmlMapper)
        {
            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate

            };

            _auth = auth;
            _consumer = consumer;
            _user = user;
            _rateLimiter = rateLimiter;

            HttpClient = new System.Net.Http.HttpClient(handler)
            {
                Timeout = DefaultTimeout,
                BaseAddress = new Uri(baseUri)
            };
        }

        public DateTime? ModifiedSince { get; set; }
        public string Where { get; set; }
        public string Order { get; set; }
        public NameValueCollection Parameters { get; set; }
        public string UserAgent { get; set; }

        public IEnumerable<TResult> Get<TResult, TResponse>(string endPoint)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(true);

            var request = CreateRequest(endPoint, HttpMethod.Get, query: queryString);

            var response = SendRequest(request);

            return Read<TResult, TResponse>(response);
        }

        internal IEnumerable<TResult> Post<TResult, TResponse>(string endpoint, byte[] data, string mimeType)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, Parameters, true);

            HttpContent content = new ByteArrayContent(data);
            content.Headers.ContentType = new MediaTypeHeaderValue(mimeType);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            var response = SendRequest(request);

            return Read<TResult, TResponse>(response);
        }

        public IEnumerable<TResult> Post<TResult, TResponse>(string endpoint, object data)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, Parameters, true);

            HttpContent content = new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            var response = SendRequest(request);

            return Read<TResult, TResponse>(response);
        }

        public IEnumerable<TResult> Put<TResult, TResponse>(string endpoint, object data)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var queryString = CreateQueryString(null, null, Parameters, true);

            HttpContent content = new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Put, content: content, query: queryString);

            var response = SendRequest(request);

            return Read<TResult, TResponse>(response);
        }

        public IEnumerable<TResult> Delete<TResult, TResponse>(string endpoint)
            where TResponse : IXeroResponse<TResult>, new()
        {
            var request = CreateRequest(endpoint, HttpMethod.Delete);

            var response = SendRequest(request);

            return Read<TResult, TResponse>(response);
        }

        internal HttpResponseMessage Get(string endpoint)
        {
            return Get(endpoint, null);
        }

        internal HttpResponseMessage Get(string endpoint, string query)
        {
            var request = CreateRequest(endpoint, HttpMethod.Get, query: query);

            return SendRequest(request);
        }

        internal HttpResponseMessage GetRaw(string endpoint, string mimetype)
        {
            var request = CreateRequest(endpoint, HttpMethod.Get, accept: mimetype);

            return SendRequest(request);
        }

        internal HttpResponseMessage Put(string endpoint, object data, bool json = false)
        {
            var queryString = CreateQueryString(null, null, Parameters, true);

            HttpContent content = json
                ? new StringContent(JsonMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationJson)
                : new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml);

            var request = CreateRequest(endpoint, HttpMethod.Put, content: content, query: queryString);

            return SendRequest(request);
        }

        internal HttpResponseMessage Post(string endpoint, object data, bool json = false)
        {
            var queryString = CreateQueryString(null, null, Parameters, true);

            HttpContent content = json
                ? new StringContent(XmlMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationXml)
                : new StringContent(JsonMapper.To(data), Encoding.UTF8, MimeTypes.ApplicationJson);

            var request = CreateRequest(endpoint, HttpMethod.Post, content: content, query: queryString);

            return SendRequest(request);
        }

        internal HttpResponseMessage Delete(string endpoint)
        {
            var request = CreateRequest(endpoint, HttpMethod.Delete);

            return SendRequest(request);
        }

        public HttpResponseMessage PostMultipartForm(string endpoint, string contentType, string name, string filename, byte[] payload)
        {
            var request = CreateRequest(endpoint, HttpMethod.Post);

            request.Content = CreateMultipartData(payload, contentType, filename);

            return HttpClient.SendAsync(request).Result;
        }

        private HttpRequestMessage CreateRequest(string endPoint, HttpMethod method, string accept = "application/json", HttpContent content = null, string query = null)
        {
            if (!string.IsNullOrWhiteSpace(query))
            {
                endPoint = string.Format("{0}?{1}", endPoint, query);
            }

            var request = new HttpRequestMessage(method, endPoint)
            {
                Content = content
            };

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(accept));

            if (ModifiedSince.HasValue)
            {
                request.Headers.IfModifiedSince = ModifiedSince;
            }

            if (_auth != null)
            {
                var oauthSignature = _auth.GetSignature(_consumer, _user, new Uri(HttpClient.BaseAddress, request.RequestUri), method.Method, _consumer);

                request.Headers.Add("Authorization", oauthSignature);
            }

            var escapedUserAgent = Uri.EscapeDataString(!string.IsNullOrWhiteSpace(UserAgent) ? UserAgent : "Xero Api wrapper - " + _consumer.ConsumerKey);

            request.Headers.UserAgent.Add(new ProductInfoHeaderValue(new ProductHeaderValue(escapedUserAgent)));

            if (_rateLimiter != null)
                _rateLimiter.WaitUntilLimit();

            return request;
        }

        private HttpResponseMessage SendRequest(HttpRequestMessage request)
        {
            return HttpClient.SendAsync(request).Result;
        }

        private string CreateQueryString(bool encoded)
        {
            return CreateQueryString(Where, Order, Parameters, encoded);
        }

        private string CreateQueryString(string where, string order, NameValueCollection paramters, bool encoded)
        {
            var generator = new QueryGenerator(where, order, paramters);

            return encoded ? generator.UrlEncodedQueryString : generator.QueryString;
        }

        private MultipartFormDataContent CreateMultipartData(byte[] bytes, string contentType, string filename)
        {
            var mp = new MultipartFormDataContent(Guid.NewGuid().ToString());
            mp.Headers.Add("Content-Type", contentType);
            mp.Headers.Add("FileName", filename);
            mp.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
            mp.Add(new ByteArrayContent(bytes));

            return mp;
        }

        internal IEnumerable<TResult> Read<TResult, TResponse>(HttpResponseMessage response)
            where TResponse : IXeroResponse<TResult>, new()
        {
            // this is the 'happy path'
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return JsonMapper.From<TResponse>(response.Content.ReadAsStringAsync().Result).Values;
            }

            HandleErrors(response);

            return null;
        }

        internal void HandleErrors(HttpResponseMessage response)
        {
            var body = response.Content.ReadAsStringAsync().Result;

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
