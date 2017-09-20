using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class UpdateTrackingOption : TrackingCategoriesTest
    {
        [Test]
        public async Task Can_update_tracking_options_name()
        {
            await Given_a_TrackingCategory_with_Option();

            await Given_first_Option_Name_change();

            await Given_Tracking_Category_is_deleted();
        }

        [Test]
        public async Task Can_update_tracking_options_status()
        {
            await Given_a_TrackingCategory_with_Options();

            await Given_approved_invoice_with_tracking_option();

            await Given_first_Option_is_Archived();

            await Given_Invoice_is_voided();

            await Given_Tracking_Category_is_deleted();

        }
    }
}
