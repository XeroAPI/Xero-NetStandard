using System.Threading.Tasks;
using CoreTests.Integration.Files.Support;
using NUnit.Framework;

namespace CoreTests.Integration.Files.Inbox
{
    [TestFixture]
    public class InboxTest : FilesTest
    {
        [Test]
        public async Task can_get_the_inbox_like_this()
        {
            var inbox = await Api.Inbox.FindInboxFolderAsync();

            Assert.IsTrue(inbox.Name == "Inbox");

            Assert.IsTrue(inbox.IsInbox);
        }
    }
}