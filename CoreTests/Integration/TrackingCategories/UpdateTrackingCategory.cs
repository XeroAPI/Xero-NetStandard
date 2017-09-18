using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class UpdateTrackingCategory : TrackingCategoriesTest
    {
        [Test]
        public void Can_update_tracking_category_name()
        {
            Given_a_TrackingCategory();

            Given_name_change_to_categorie();

            Given_Tracking_Category_is_deleted();
        }

        [Test]
        public void Can_update_tracking_category_with_Options_name()
        {
            Given_a_TrackingCategory_with_Options();

            Given_name_change_to_categorie();

            Given_Tracking_Category_is_deleted();
        }
    }
}
