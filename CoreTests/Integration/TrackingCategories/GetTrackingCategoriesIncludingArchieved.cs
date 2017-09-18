using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class GetTrackingCategoriesIncludingArchieved : TrackingCategoriesTest
    {
        [Test]
        public void Can_get_Tracking_Category_including_archieved()
        {
            Given_a_TrackingCategory_with_Options();

            Given_approved_invoice_with_tracking_option();

            Given_Tracking_Category_is_Archived();

            Given_GetAll_with_Archived();

            Then_Archieved_Tracking_Category_is_in_list();

            Given_Invoice_is_voided();
            Given_Tracking_Category_is_deleted();
        }
    }
}
