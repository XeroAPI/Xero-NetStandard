using System;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PayrollTests.AU.Integration.Settings
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_all()
        {
            var settings = await Api.Settings.FindAsync();
            Assert.IsNotNull(settings);

            foreach (var s in settings)
            {
                Assert.True(s.Accounts.All(p => p.Id != Guid.Empty));
            }
        }
    }
}
