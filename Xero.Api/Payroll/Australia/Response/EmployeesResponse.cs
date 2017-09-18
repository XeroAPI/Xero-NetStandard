using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model;

namespace Xero.Api.Payroll.Australia.Response
{
    public class EmployeesResponse : XeroResponse<Employee>
    {
        public IList<Employee> Employees { get; set; }

        public override IList<Employee> Values
        {
            get { return Employees; }
        }
    }
}