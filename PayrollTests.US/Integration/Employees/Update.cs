using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.America.Model;

namespace PayrollTests.US.Integration.Employees
{
    [TestFixture]
    public class Update : EmployeesTest
    {
        [Test]
        public async Task update_employee_with_super_memberhsip()
        {
            var emp = await Given_an_employee();

            var updated_emp = await Api.UpdateAsync(new Employee
            {
                Id = emp.Id,
            });
            Assert.IsTrue(updated_emp.Id != Guid.Empty);
        }

    }
}
