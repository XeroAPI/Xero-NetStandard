using System;
using System.Collections;
using System.Net;
using System.Threading.Tasks;
using CoreTests.Integration.Files.Support;
using NUnit.Framework;
using Xero.Api.Core.Endpoints;
using Xero.Api.Core.Model;
using File = Xero.Api.Core.Model.File;

namespace CoreTests.Integration.Files.Files
{
    [TestFixture]
    public class AddFileTest : FilesTest
    {
        [Test]
        public async Task can_get_all_files_like_this()
        {
            var result = await Api.Files.FindAsync();

            Assert.True(result != null);
        }

        [Test]
        public async Task can_get_the_content_of_a_file_like_this()
        {
            var filename = "My Test File " + Guid.NewGuid() + ".png";

            var inboxId = (await Api.Inbox.FindInboxFolderAsync()).Id;

            var id = await Given_a_file_in(inboxId, filename);

            var content = await Api.Files.GetContentAsync(id,"image/png");
            
            Assert.IsTrue(StructuralComparisons.StructuralEqualityComparer.Equals(content,exampleFile));
        }
        
        [Test]
        public async Task can_remove_a_file_like_this()
        {
            var inboxId = (await Api.Inbox.FindInboxFolderAsync()).Id;

            var result = await Given_a_file_in(inboxId, "Test " + Guid.NewGuid()  + ".png");

            await Api.Files.RemoveAsync(result);

            var notfound = await Api.Files.FindAsync(result);

            Assert.IsNull(notfound);

        }

       [Test]
       public async Task can_rename_a_file_like_this()
       {
           var inboxId = (await Api.Inbox.FindInboxFolderAsync()).Id;

           var result = await Given_a_file_in(inboxId, "Test " + Guid.NewGuid()  + ".png");

           var copy = await Api.Files.FindAsync(result);

           var NewName = "someother name.png";

           var updateResult = await Api.Files.RenameAsync(copy.Id, NewName);

           Assert.IsTrue(updateResult.Name == NewName);

       }

       [Test]
       public async Task can_move_a_file_like_this()
       {
           var inboxId = (await Api.Inbox.FindInboxFolderAsync()).Id;

           var result = await Given_a_file_in(inboxId, "Test " + Guid.NewGuid() + ".png");

           var newFolder = await Api.Folders.AddAsync("stuff");

           var updateResult = await Api.Files.MoveAsync(result, newFolder.Id);

           Assert.IsTrue(updateResult.FolderId == newFolder.Id);
       }

       private File create_file_with_name(string filename)
       {
           return new Xero.Api.Core.Model.File()
           {
               Name = filename,
               FileName = filename,
               Mimetype = "image/png",
               User = new FilesUser()
               {
                   FirstName = "Bart",
                   LastName = "Simpson",
                   FullName = "Bart Simpson",
                   Name = "Bart@gmail.com"
               }
           };
       }
    }

}
