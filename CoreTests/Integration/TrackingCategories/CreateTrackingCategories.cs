using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.TrackingCategories
{
    [TestFixture]
    public class CreateTrackingCategories : TrackingCategoriesTest
    {
        [Test]
        public async Task Can_create_a_Tracking_Category()
        {
            await Given_a_TrackingCategory();

            await Given_Tracking_Category_is_deleted();
        }
    }
}