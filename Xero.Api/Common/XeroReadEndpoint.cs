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
            _modifiedSince = modified;
            return (T)this;
        }

        public T Where(string query)
        {
            _query = query;
            return (T)this;
        }

        public T Or(string query)
        {
            _query = string.Concat(_query, " OR ", query);
            return (T)this;
        }

        public T And(string query)
        {
            _query = string.Concat(_query, " AND ", query);
            return (T)this;
        }

        public T OrderBy(string query)
        {
            _orderBy = query;
            return (T)this;
        }

        public T OrderByDescending(string query)
        {
            _orderBy = query + " DESC";
            return (T)this;
        }

        public T UseFourDecimalPlaces(bool use4Dp)
        {
            Apply4Dp(use4Dp);

            return (T)this;
        }

        public virtual async Task<IEnumerable<TResult>> FindAsync()
        {
            return await GetAsync(ApiEndpointUrl, null);
        }

        public virtual async Task<TResult> FindAsync(Guid child)
        {
            return await FindAsync(child.ToString("D"));
        }

        public async Task<TResult> FindAsync(string child)
        {
            var results = await GetAsync(ApiEndpointUrl, "/" + child);

            return results.FirstOrDefault();
        }

        public virtual void ClearQueryString()
        {
            _orderBy = null;
            _query = null;
            _modifiedSince = null;
            Parameters = null;
        }

        protected void Apply4Dp(bool use4Dp)
        {
            const string name = "unitdp";

            if (use4Dp)
            {
                AddParameter(name, 4);
            }
            else
            {
                RemoveParameter(name);
            }
        }

        public string QueryString
        {
            get
            {
                return new QueryGenerator(_query, _orderBy, Parameters).QueryString;
            }
        }

        internal protected T AddParameter(string name, int value)
        {
            return AddParameter(name, value.ToString("D"));
        }

        internal protected T AddParameter(string name, bool value)
        {
            return AddParameter(name, value.ToString().ToLower());
        }

        internal void RemoveParameter(string name)
        {
            if (Parameters != null)
            {
                Parameters.Remove(name);
            }
        }

        internal protected T AddParameter(string name, string value)
        {
            if (Parameters == null)
            {
                Parameters = new NameValueCollection();
            }

            Parameters[name] = value;

            return (T)this;
        }

        internal protected T AddParameters(NameValueCollection parameters)
        {
            if (Parameters == null)
            {
                Parameters = parameters;
            }
            else
            {
                Parameters.Add(parameters);
            }

            return (T)this;
        }

        private async Task<IEnumerable<TResult>> GetAsync(string endpoint, string child)
        {
            try
            {
                if (Parameters == null)
                {
                    Parameters = new NameValueCollection();
                }

                Client.Where = _query;
                Client.Order = _orderBy;
                Client.ModifiedSince = _modifiedSince;
                Client.Parameters = Parameters;

                return await Client.GetAsync<TResult, TResponse>(endpoint + (child ?? string.Empty));
            }
            finally
            {
                ClearQueryString();
            }
        }
    }
}
