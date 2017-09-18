using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class ArchiveTrackingCategory : TrackingCategoriesTest
    {
        [Test]
        public void Can_archieve_tracking_category()
        {
            Given_a_TrackingCategory_with_Options();

            Given_approved_invoice_with_tracking_option();

            Given_Tracking_Category_is_Archived();

            Given_Invoice_is_voided();
            Given_Tracking_Category_is_deleted();
        }
    }
}
