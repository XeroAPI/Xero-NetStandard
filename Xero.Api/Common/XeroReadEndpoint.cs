using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Common
{
    public abstract class XeroReadEndpoint<T, TResult, TResponse> : IXeroReadEndpoint<T, TResult, TResponse> 
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
    {
        private DateTime? _modifiedSince;
        private string _query;
        private string _orderBy;
        
        protected NameValueCollection Parameters { get; private set; }

        protected string ApiEndpointUrl { get; private set; }
        public XeroHttpClient Client { get; private set; }

        protected XeroReadEndpoint(XeroHttpClient client, string apiEndpointUrl)
        {
            Client = client;
            ApiEndpointUrl = apiEndpointUrl;
        }

        public T ModifiedSince(DateTime modified)
        {
            var endpoint = (T)Clone();
            endpoint._modifiedSince = modified;
            return endpoint;
        }

        public T Where(string query)
        {
            var endpoint = (T)Clone();
            endpoint._query = query;
            return endpoint;
        }

        public T Or(string query)
        {
            var endpoint = (T)Clone();
            endpoint._query = string.Concat(_query, " OR ", query);
            return endpoint;
        }

        public T And(string query)
        {
            var endpoint = (T) Clone();
            endpoint._query = string.Concat(_query, " AND ", query);
            return endpoint;
        }

        public T OrderBy(string query)
        {
            var endpoint = (T) Clone();
            endpoint._orderBy = query;
            return endpoint;
        }

        public T OrderByDescending(string query)
        {
            var endpoint = (T) Clone();
            endpoint._orderBy = query + " DESC";
            return endpoint;
        }

        public T UseFourDecimalPlaces(bool use4Dp)
        {
            return Apply4Dp(use4Dp);
        }

        public virtual Task<IEnumerable<TResult>> FindAsync()
        {
            return GetAsync(ApiEndpointUrl, null);
        }

        public virtual Task<TResult> FindAsync(Guid child)
        {
            return FindAsync(child.ToString("D"));
        }

        public async Task<TResult> FindAsync(string child)
        {
            var results = await GetAsync(ApiEndpointUrl, "/" + child).ConfigureAwait(false);

            return results.FirstOrDefault();
        }

        public virtual void ClearQueryString()
        {
            _orderBy = null;
            _query = null;
            _modifiedSince = null;
            Parameters = null;
        }

        protected T Apply4Dp(bool use4Dp, bool clone = true)
        {
            const string name = "unitdp";

            return use4Dp ? AddParameter(name, 4, clone) : RemoveParameter(name, clone);
        }

        public string QueryString
        {
            get
            {
                return new QueryGenerator(_query, _orderBy, Parameters).QueryString;
            }
        }

        internal protected T AddParameter(string name, int value, bool clone = true)
        {
            return AddParameter(name, value.ToString("D"), clone);
        }


        internal protected T AddParameter(string name, bool value, bool clone = true)
        {
            return AddParameter(name, value.ToString().ToLower(), clone);
        }

        // Note: Use clone = false when adding parameters from a constructor to ensure that the parameter 'sticks'
        internal protected T AddParameter(string name, string value, bool clone = true)
        {
            var endpoint = (T) (clone ? Clone() : this);

            if (endpoint.Parameters == null)
            {
                endpoint.Parameters = new NameValueCollection();
            }

            endpoint.Parameters[name] = value;

            return endpoint;
        }

        internal protected T AddParameters(NameValueCollection parameters, bool clone = true)
        {
            var endpoint = clone ? (T) Clone() : (T)this;
            
            if (endpoint.Parameters == null)
            {
                endpoint.Parameters = parameters;
            }
            else
            {
                endpoint.Parameters.Add(parameters);
            }

            return endpoint;
        }

        internal T RemoveParameter(string name, bool clone = true)
        {
            var endpoint = (T) (clone ? Clone() : this);

            endpoint.Parameters?.Remove(name);

            return endpoint;
        }

        private async Task<IEnumerable<TResult>> GetAsync(string endpoint, string child)
        {
            try
            {
                endpoint = endpoint + (child ?? string.Empty);
                return await Client.GetAsync<TResult, TResponse>(endpoint, Parameters, _query, _orderBy, _modifiedSince).ConfigureAwait(false);
            }
            finally
            {
                ClearQueryString();
            }
        }

        public object Clone()
        {
            var clone = (T) MemberwiseClone();

            clone.Client = Client;

            if (Parameters != null)
            {
                clone.Parameters = new NameValueCollection(Parameters);
            }

            return clone;
        }
    }
}
