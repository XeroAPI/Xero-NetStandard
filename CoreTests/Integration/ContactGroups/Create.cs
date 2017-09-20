using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.ContactGroups
{
    [TestFixture]
    public class Create : ContactGroupsTest
    {
        [Test]
        public async Task Can_I_create_a_contactgroup()
        {
           var name= (await Given_a_contactgroup()).Name;
           
            Assert.IsTrue(name.StartsWith("Nice People"));

        }
    }
}
