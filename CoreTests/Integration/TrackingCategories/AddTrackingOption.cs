using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class AddTrackingOption : TrackingCategoriesTest
    {
        [Test]
        public async Task Can_add_tracking_option()
        {
            await Given_a_TrackingCategory_with_Option();

            await Then_Category_Has_Option();

            await Given_Tracking_Category_is_deleted();
        }

        [Test]
        public async Task Can_add_tracking_options()
        {
            await Given_a_TrackingCategory_with_Options();

            await Then_Category_Has_Options();

            await Given_Tracking_Category_is_deleted();
        }
    }
}
