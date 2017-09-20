using System;
using System.Threading.Tasks;
using Xero.Api.Payroll.America.Model;

namespace PayrollTests.US.Integration.Employees
{
    public abstract class EmployeesTest : ApiWrapperTest
    {
        protected async Task<Employee> Given_an_employee()
        {
            return await Api.CreateAsync(new Employee
            {
                FirstName = "John " + Guid.NewGuid().ToString("N"),
                LastName = "Smith",
            });
        }
    }
}
