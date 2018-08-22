using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IEmployeesEndpoint : IXeroUpdateEndpoint<EmployeesEndpoint, Employee, EmployeesRequest, EmployeesResponse>
    {

    }

    public class EmployeesEndpoint
        : XeroUpdateEndpoint<EmployeesEndpoint, Employee, EmployeesRequest, EmployeesResponse>, IEmployeesEndpoint
    {
        public EmployeesEndpoint(XeroHttpClient client) 
            : this(client, "/api.xro/2.0")
        {
        }

        public EmployeesEndpoint(XeroHttpClient client, string endpointBase) 
            : base(client, $"{endpointBase}/Employees")
        {
        }
    }
}