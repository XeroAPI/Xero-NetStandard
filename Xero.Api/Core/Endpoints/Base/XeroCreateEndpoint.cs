using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Core.Endpoints.Base
{
    public abstract class XeroCreateEndpoint<T, TResult, TRequest, TResponse>
        : XeroReadEndpoint<T, TResult, TResponse>, IXeroCreateEndpoint<T, TResult, TRequest, TResponse>
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
        where TRequest : IXeroRequest<TResult>, new()
    {
        protected XeroCreateEndpoint(XeroHttpClient client, string apiEndpointUrl)
            : base(client, apiEndpointUrl)
        {
        }

        public async Task<IEnumerable<TResult>> CreateAsync(IEnumerable<TResult> items)
        {
            var request = new TRequest();
            request.AddRange(items);

            return await PutAsync(request);
        }

        public async Task<TResult> CreateAsync(TResult item)
        {
            return (await CreateAsync(new[] { item })).First();
        }

        public IXeroCreateEndpoint<T, TResult, TRequest, TResponse> SummarizeErrors(bool summarize)
        {
            AddParameter("summarizeErrors", summarize);
            return this;
        }

        protected async Task<IEnumerable<TResult>> PutAsync(TRequest data)
        {
            try
            {
                Client.Parameters = Parameters;
                return await Client.PutAsync<TResult, TResponse>(ApiEndpointUrl, data);
            }
            finally
            {
                ClearQueryString();            
            }
        }        
    }
}
