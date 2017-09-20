using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.Files.Associations
{
    [TestFixture]
    public class AssociationTest : ApiWrapperTest
    {
        private async Task<Guid> FindAFileId()
        {
            var file = (await Api.Files.FindAsync()).FirstOrDefault();
            return file?.Id ?? Guid.Empty;
        }

        private async Task<Guid> FindAnInvoiceId()
        {
            var invoice = (await Api.Invoices.FindAsync()).FirstOrDefault();
            return invoice?.Id ?? Guid.Empty;
        }

        [Test]
        public async Task AssociationsForFile()
        {
            var fileId = await FindAFileId();

            Assert.DoesNotThrowAsync(() => Api.Associations.FindAsync(fileId));
        }

        [Test]
        public async Task AssociationsForObject()
        {
            var objectId = await FindAnInvoiceId();

            Assert.DoesNotThrowAsync(() => Api.Associations.FindForObjectAsync(objectId));
        }

        // This is not a great test - but it needs to run in sequence and clean up after itself
        // (if it happens to be working with an association that should already exist, then we have a problem...)
        [Test]
        public async Task AssociationCreateFindAndDelete()
        {
            var fileId = await FindAFileId();
            var objectId = await FindAnInvoiceId();

            var toCreate = new Association
            {
                FileId = fileId,
                ObjectId = objectId,
                ObjectGroup = ObjectGroupType.Invoice
            };

            Assert.DoesNotThrowAsync(() => Api.Associations.CreateAsync(toCreate));

            Assert.DoesNotThrowAsync(() => Api.Associations.FindAsync(fileId, objectId));

            var toDelete = new Association
            {
                FileId = fileId,
                ObjectId = objectId,
                ObjectGroup = ObjectGroupType.Invoice
            };

            Assert.DoesNotThrowAsync(() => Api.Associations.DeleteAsync(toDelete));
        }
    }
}