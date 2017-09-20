using System;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;

namespace CoreTests.Integration.Contacts
{
    public abstract  class ContactsTest : ApiWrapperTest
    {
        private TrackingCategory _trackingCat;
        private bool _wasTcCreated = false;

        protected async Task<Contact> Given_a_contact()
        {
            return await Api.CreateAsync(new Contact
            {
                Name = "Peter " + Random.GetRandomString(10)
            });
        }

        protected async Task<TrackingCategory> FindOrCreateTc(string OptionName, string TCName)
        {
            _trackingCat = (await Api.TrackingCategories.FindAsync()).FirstOrDefault();
            if (_trackingCat == null || _trackingCat.Options.FirstOrDefault() == null)
            {
                var option1 = new Option()
                {
                    Id = Guid.Empty,
                    Name = OptionName,
                    Status = TrackingOptionStatus.Active
                };


                _trackingCat = await Api.TrackingCategories.CreateAsync(new TrackingCategory()
                {
                    Name = TCName,
                    Status = TrackingCategoryStatus.Active
                });

                await Api.TrackingCategories.AddOptionAsync(_trackingCat, option1);

                _trackingCat = await Api.TrackingCategories.FindAsync(_trackingCat.Id);
                _wasTcCreated = true;
            }
            return _trackingCat;
        }

        protected async Task DeleteCreatedTc(TrackingCategory tc)
        {
            if (_wasTcCreated)
            {
                await Api.TrackingCategories.DeleteAsync(_trackingCat);
                _wasTcCreated = false;
            }
        }
    }
}
