using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Payroll.America.Model;
using Xero.Api.Payroll.America.Model.Types;

namespace PayrollTests.US.Integration.Employees
{
    [TestFixture]
    public class Create : EmployeesTest
    {
        [Test]
        public async Task create_employee()
        {
            var emp = await Api.CreateAsync(new Employee
            {
                FirstName = "John",
                LastName = "Smith",
                HomeAddress =
                    new HomeAddress
                    {
                        StreetAddress = "244 Jackson St",
                        SuiteOrApartmentOrUnit = "10",
                        City = "San Francisco",
                        State = State.California,
                        ZipCode = 94111,
                        Latitude = 37.79690m,
                        Longitude = -122.40033m
                    },
                DateOfBirth = new DateTime(1984, 02, 05)
            });

            Assert.IsTrue(Guid.Empty != emp.Id);
            Assert.AreEqual("John", emp.FirstName);
        }
    }
}
