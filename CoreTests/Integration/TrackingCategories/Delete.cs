using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class Delete : TrackingCategoriesTest
    {
        [Test]
        public void can_delete_a_Tracking_Category()
        {
            Given_a_TrackingCategory();

            Given_Tracking_Category_is_deleted();
        }

        [Test]
        public void can_delete_a_Tracking_Category_Option()
        {
            Given_a_TrackingCategory_with_Options();

            Given_Tracking_CategoryOption_is_deleted();


            Given_Tracking_Category_is_deleted();
        }

    }
}
