using System;
using System.IO;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.Files.Support
{
    public class FilesTest : ApiWrapperTest
    {
        protected byte[] exampleFile;
        private const string ImagePath = @"connect_xero_button_blue.png";

        public FilesTest()
        {
            exampleFile = GetFileBytes("xero", ImagePath);
        }
        
        private Xero.Api.Core.Model.File create_file_with_name(string filename)
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

        protected async Task<Guid> Given_a_file_in(Guid folderId, string filename)
        {
            var file = create_file_with_name(filename);

            return await Given_a_file_in(folderId, file);

        }

        protected async Task<Guid> Given_a_file_in(Guid folderId)
        {
            var filename = "Test" + Guid.NewGuid() + ".png";

            return await Given_a_file_in(folderId, create_file_with_name(filename));    
        }

        protected async Task<Guid> Given_a_file_in(Guid folderId,Xero.Api.Core.Model.File file )
        {
            var result = await Api.Files.AddAsync(folderId, file, exampleFile);

            return result.Id ;
        }
        
        internal static byte[] GetFileBytes(string name, string fileName)
        {
            var file = new FileInfo(new DiskFile(name, fileName).Path);

            var data = new DataItem(file);
            byte[] bytes;

            using (var ms = new MemoryStream())
            {
                data.Content.CopyTo(ms);
                bytes = ms.ToArray();
            }

            return bytes;
        }
    }
}