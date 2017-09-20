using System;
using System.Linq;
using System.Threading.Tasks;
using CoreTests.Integration.Files.Support;
using NUnit.Framework;

namespace CoreTests.Integration.Files.Folders
{
    public class AddFolderTest : FilesTest
    {
        [Test]
        public void can_create_a_folder_like_this()
        {
            Assert.DoesNotThrowAsync(() => Api.Folders.AddAsync("Test Folder" + Guid.NewGuid()));
        }


        [Test]
        public async Task can_get_all_folders_like_this()
        {
            var allFolders = (await Api.Folders.FindAsync()).ToList();

            Assert.True(allFolders[0].Name == "Inbox");

            Assert.True(allFolders[1].Name == "Contracts");

        }

        [Test]
        public async Task can_remove_a_folder_like_this()
        {
            var folder = await Api.Folders.AddAsync("Test Folder" + Guid.NewGuid());

            Assert.DoesNotThrowAsync(() => Api.Folders.RemoveAsync(folder.Id)); // Hint ->folder is empty
        }
      }
}