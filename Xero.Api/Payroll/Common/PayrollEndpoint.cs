using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Payroll.Common
{
    public abstract class PayrollEndpoint<T, TResult, TRequest, TResponse>
        : XeroReadEndpoint<T, TResult, TResponse>
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
        where TRequest : IXeroRequest<TResult>, new()
    {
        protected PayrollEndpoint(XeroHttpClient client, string apiEndpointUrl)
            : base(client, apiEndpointUrl)
        {
        }

        public Task<IEnumerable<TResult>> CreateAsync(IEnumerable<TResult> items)
        {
            var request = new TRequest();
            request.AddRange(items);

            return PostAsync(request);
        }

        public async Task<TResult> CreateAsync(TResult item)
        {
            return (await CreateAsync(new [] { item }).ConfigureAwait(false)).First();
        }

        public Task<IEnumerable<TResult>> UpdateAsync(IEnumerable<TResult> items)
        {
            return CreateAsync(items);
        }

        public async Task<TResult> UpdateAsync(TResult item)
        {
            return (await UpdateAsync(new[] { item }).ConfigureAwait(false)).First();
        }

        protected Task<IEnumerable<TResult>> PostAsync(TRequest data)
        {
            return Client.PostAsync<TResult, TResponse>(ApiEndpointUrl, data);
        }

        public T Page(int page)
        {
            return AddParameter("page", page);
        }

    }
}
