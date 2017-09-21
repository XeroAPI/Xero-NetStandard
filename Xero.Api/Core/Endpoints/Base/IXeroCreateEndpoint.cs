using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Core.Endpoints.Base
{
    public interface IXeroCreateEndpoint<T, TResult, TRequest, TResponse>
        : IXeroReadEndpoint<T, TResult, TResponse>
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
        where TRequest : IXeroRequest<TResult>, new()
    {
        Task<IEnumerable<TResult>> CreateAsync(IEnumerable<TResult> items);
        Task<TResult> CreateAsync(TResult item);
        T SummarizeErrors(bool summarize);
    }
}
