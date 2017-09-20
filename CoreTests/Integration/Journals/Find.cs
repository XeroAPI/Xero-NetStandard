using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.Journals
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_journals()
        {
            var journals = await Api.Journals.FindAsync();

            Assert.That(journals.Any());
        }

        [Test]
        public async Task find_journals_offset()
        {
            var journals = (await Api.Journals.FindAsync()).ToList();

            if (journals.Count() == 100)
            {
                var offset = journals.Max(p => p.Number);

                Assert.That((await Api.Journals.Offset(offset)
                    .FindAsync())
                    .Any());
            }
        }
    }
}
