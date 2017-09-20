using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;

namespace PayrollTests.AU.Integration.Employees
{
    [TestFixture]
    public class Update : EmployeesTest
    {
        [Test]
        public async Task update_employee_with_super_memberhsip()
        {
            var emp = await Given_an_employee(false);
            var superFundId = await super_fund_id();

            var updated_emp = await Api.UpdateAsync(new Employee
            {
                Id = emp.Id,
                SuperMemberships = new List<SuperMembership>
                {
                    new SuperMembership
                    {
                        SuperFundId = superFundId,
                        EmployeeNumber = 3424232
                    }
                }
                
            });
            Assert.IsTrue(updated_emp.Id != Guid.Empty);
        }

    }
}
