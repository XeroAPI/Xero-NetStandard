using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Common
{
    public interface IXeroReadEndpoint<T, TResult, TResponse> : ICloneable
        where T : XeroReadEndpoint<T, TResult, TResponse>
        where TResponse : IXeroResponse<TResult>, new()
    {
        string QueryString { get; }
        T ModifiedSince(DateTime modified);
        T Where(string query);
        T Or(string query);
        T And(string query);
        T OrderBy(string query);
        T OrderByDescending(string query);
        T UseFourDecimalPlaces(bool use4Dp);
        Task<IEnumerable<TResult>> FindAsync();
        Task<TResult> FindAsync(Guid child);
        Task<TResult> FindAsync(string child);
        void ClearQueryString();
    }
}