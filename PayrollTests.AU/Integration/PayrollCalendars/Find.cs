using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.PayrollCalendars
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_all()
        {
            var prc = await Api.PayrollCalendars.FindAsync();
            Assert.True(prc.Any());
            Assert.True(prc.FirstOrDefault().Id != Guid.Empty);
        }

        [Test]
        public async Task find_paged()
        {
            var prc = await Api.PayrollCalendars.Page(1).FindAsync();
            Assert.True(prc.Any());
            Assert.True(prc.FirstOrDefault().Id != Guid.Empty);
        }
    }
}
