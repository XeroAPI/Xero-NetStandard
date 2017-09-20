using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class UpdateTrackingCategory : TrackingCategoriesTest
    {
        [Test]
        public async Task Can_update_tracking_category_name()
        {
            await Given_a_TrackingCategory();

            await Given_name_change_to_categorie();

            await Given_Tracking_Category_is_deleted();
        }

        [Test]
        public async Task Can_update_tracking_category_with_Options_name()
        {
            await Given_a_TrackingCategory_with_Options();

            await Given_name_change_to_categorie();

            await Given_Tracking_Category_is_deleted();
        }
    }
}
