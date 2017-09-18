using System;
using System.Collections.Generic;
using NUnit.Framework;
using Xero.Api.Payroll.Australia.Model;

namespace PayrollTests.AU.Integration.Employees
{
    [TestFixture]
    public class Update : EmployeesTest
    {
        [Test]
        public void update_employee_with_super_memberhsip()
        {
            var emp = Given_an_employee(false);

            var updated_emp = Api.Update(new Employee
            {
                Id = emp.Id,
                SuperMemberships = new List<SuperMembership>
                {
                    new SuperMembership
                    {
                        SuperFundId = super_fund_id(),
                        EmployeeNumber = 3424232
                    }
                }
                
            });
            Assert.IsTrue(updated_emp.Id != Guid.Empty);
        }

    }
}
