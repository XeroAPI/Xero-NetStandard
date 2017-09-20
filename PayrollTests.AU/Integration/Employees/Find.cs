using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.Employees
{
    [TestFixture]
    public class Find : EmployeesTest
    {
        [Test]
        public async Task find_all_employees()
        {
            var emp = await Api.Employees.FindAsync();
            Assert.Greater(emp.Count(), 0);
        }

        [Test]
        public async Task find_by_id()
        {
            var expected = (await Given_an_employee()).Id;
            var employee = await Api.Employees.FindAsync(expected);

            Assert.AreEqual(expected, employee.Id);
        }

        [Test]
        public async Task find_by_status()
        {
            var terminated = await given_terminated_employee();

            Assert.True((await Api.Employees
                .Where("Status == \"TERMINATED\"")
                .FindAsync())
                .Select(p => p.Id)
                .Any(p => p == terminated.Id));            
        }

        [Test]
        public async Task find_all_employees_paged()
        {
            var emp = await Api.Employees.Page(1).FindAsync();
            Assert.Greater(emp.Count(), 0);
        }
    }
}
