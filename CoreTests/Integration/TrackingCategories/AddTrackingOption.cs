using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class AddTrackingOption : TrackingCategoriesTest
    {
        [Test]
        public void Can_add_tracking_option()
        {
            Given_a_TrackingCategory_with_Option();

            Then_Category_Has_Option();

            Given_Tracking_Category_is_deleted();
        }

        [Test]
        public void Can_add_tracking_options()
        {
            Given_a_TrackingCategory_with_Options();

            Then_Category_Has_Options();

            Given_Tracking_Category_is_deleted();
        }
    }
}
