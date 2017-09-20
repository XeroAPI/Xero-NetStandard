using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Core.Endpoints.Base
{
    public interface IXeroUpdateEndpoint<T, TResult, TRequest, TResponse>
        : IXeroCreateEndpoint<T, TResult, TRequest, TResponse>
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
        where TRequest : IXeroRequest<TResult>, new()
    {
        Task<IEnumerable<TResult>> UpdateAsync(IEnumerable<TResult> items);
        Task<TResult> UpdateAsync(TResult item);
        new IXeroUpdateEndpoint<T, TResult, TRequest, TResponse> SummarizeErrors(bool summarize);
    }
}
