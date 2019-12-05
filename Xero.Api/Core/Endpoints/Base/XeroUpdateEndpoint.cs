using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Core.Endpoints.Base
{
    public abstract class XeroUpdateEndpoint<T, TResult, TRequest, TResponse>
        : XeroCreateEndpoint<T, TResult, TRequest, TResponse>, IXeroUpdateEndpoint<T, TResult, TRequest, TResponse>
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
        where TRequest : IXeroRequest<TResult>, new()
    {
        protected XeroUpdateEndpoint(XeroHttpClient client, string apiEndpointUrl)
            : base(client, apiEndpointUrl)
        {
        }

        public Task<IEnumerable<TResult>> UpdateAsync(IEnumerable<TResult> items)
        {
            var request = new TRequest();
            request.AddRange(items);

            return PostAsync(request);
        }

        public virtual async Task<TResult> UpdateAsync(TResult item)
        {
            return (await UpdateAsync(new[] { item }).ConfigureAwait(false)).First();
        }

        protected async Task<IEnumerable<TResult>> PostAsync(TRequest data)
        {
            try
            {
                return await Client.PostAsync<TResult, TResponse>(ApiEndpointUrl, data, Parameters).ConfigureAwait(false);
            }
            finally
            {
                ClearQueryString();
            }
        }
        
        public IXeroUpdateEndpoint<T, TResult, TRequest, TResponse>  SummarizeErrors(bool summarize)
        {
            return (IXeroUpdateEndpoint<T, TResult, TRequest, TResponse>) AddParameter("summarizeErrors", summarize);
        }
    }
}
