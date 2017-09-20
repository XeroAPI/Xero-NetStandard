using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.TrackingCategories
{
    public class TrackingCategoriesTest : ApiWrapperTest
    {
        private Invoice _invoice;
        public TrackingCategory Category1;
        public TrackingCategory Category2;
        private List<TrackingCategory> _listresult;

        public async Task Given_a_TrackingCategory_with_Options()
        {
            await Given_a_TrackingCategory();

            var option1 = Given_a_tracking_option();
            var option2 = Given_a_tracking_option();

            await Api.TrackingCategories.AddOptionAsync(Category1, option1);
            await Api.TrackingCategories.AddOptionAsync(Category1, option2);

            Category1 = await Api.TrackingCategories.FindAsync(Category1.Id);
        }

        public async Task Given_a_TrackingCategory_with_Option()
        {
            await Given_a_TrackingCategory();

            var option1 = Given_a_tracking_option();

            await Api.TrackingCategories.AddOptionAsync(Category1, option1);

            Category1 = await Api.TrackingCategories.FindAsync(Category1.Id);
        }

        public async Task Given_a_TrackingCategory()
        {
            Category1 = await Api.TrackingCategories.CreateAsync(new TrackingCategory
            {
                Name = "TheJoker " + Guid.NewGuid(),
                Status = TrackingCategoryStatus.Active
            });

            Assert.IsTrue(Category1.Name.StartsWith("TheJoker"));

            Assert.IsTrue(Category1.Status == TrackingCategoryStatus.Active);
        }

        public async Task Given_two_TrackingCategorys()
        {
            Category1 = await Api.TrackingCategories.CreateAsync(new TrackingCategory
            {
                Name = "TheJoker " + Guid.NewGuid(),
                Status = TrackingCategoryStatus.Active
            });

            Category2 = await Api.TrackingCategories.CreateAsync(new TrackingCategory
            {
                Name = "HarleyQuinn " + Guid.NewGuid(),
                Status = TrackingCategoryStatus.Active
            });
        }

        public Option Given_a_tracking_option()
        {
            return new Option()
            {
                Id = Guid.Empty,
                Name = "Option " + Guid.NewGuid(),
                Status = TrackingOptionStatus.Active
            };
        }

        public List<Option> Given_a_tracking_options()
        {
            List<Option> options = new List<Option>();

            options.Add(Given_a_tracking_option());
            options.Add(Given_a_tracking_option());

            return options;
        }

        public async Task Given_name_change_to_categorie()
        {
            Category1.Name = "The Joker";

            var result = await Api.UpdateAsync(Category1);

            Assert.True(result.Name == "The Joker");
        }

        public async Task Given_approved_invoice_with_tracking_option(InvoiceType type = InvoiceType.AccountsPayable, InvoiceStatus status = InvoiceStatus.Draft)
        {
            Guid category = Category1.Id;
            string name = Category1.Name;
            string option = Category1.Options.FirstOrDefault().Name;

            var inv = await Api.CreateAsync(new Invoice
            {
                Contact = new Contact { Name = "Wayne Enterprises" },
                Type = type,
                Date = DateTime.UtcNow,
                DueDate = DateTime.UtcNow.AddDays(90),
                LineAmountTypes = LineAmountType.Inclusive,
                Status = status,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        AccountCode = "200",
                        Description = "Good value item",
                        LineAmount = 100m,
                        Tracking = new ItemTracking
                        {
                            new ItemTrackingCategory
                            {
                                Id = category,
                                Name = name,
                                Option = option
                            }
                        }
                    }
                }

            });

            inv.Status = InvoiceStatus.Authorised;
            _invoice = await Api.UpdateAsync(inv);
        }

        public async Task<Invoice> Given_Invoice_is_voided()
        {
            _invoice.Status = InvoiceStatus.Voided;
            return await Api.UpdateAsync(_invoice);
        }

        public async Task Given_Tracking_Category_is_deleted()
        {
            await Api.TrackingCategories.DeleteAsync(Category1);
        }

        public async Task Given_both_Tracking_Category_is_deleted()
        {
            await Given_Tracking_Category_is_deleted();

            await Api.TrackingCategories.DeleteAsync(Category2);
            
        }

        public async Task Given_Tracking_CategoryOption_is_deleted()
        {
            await Api.TrackingCategories.DeleteTrackingOptionAsync(Category1, Category1.Options.FirstOrDefault());
        }

        public async Task Given_first_Option_is_Archived()
        {
            Category1.Options.FirstOrDefault().Status = TrackingOptionStatus.Archived;

            var result = await Api.TrackingCategories.UpdateOptionAsync(Category1, Category1.Options.FirstOrDefault());

            Assert.True(result.FirstOrDefault().Status == TrackingOptionStatus.Archived);
        }

        public async Task Given_Tracking_Category_is_Archived()
        {
            Category1.Status = TrackingCategoryStatus.Archived;

            Category1 = await Api.TrackingCategories.UpdateAsync(Category1);

            Assert.True(Category1.Status == TrackingCategoryStatus.Archived);
        }

        public async Task Given_first_Option_Name_change()
        {
            var option = Category1.Options.FirstOrDefault();

            option.Name = "Mr Freeze";

            option = (await Api.TrackingCategories.UpdateOptionAsync(Category1, option)).FirstOrDefault();

            Assert.True(option.Name == "Mr Freeze");
        }

        public async Task Then_Category_Has_Option()
        {
            var result = await Api.TrackingCategories.FindAsync(Category1.Id);

            Assert.True(result != null);

            //            Assert.True(result._trackingCat.Options.Any(i => i.Name == options.FirstOrDefault().Name));
            //            Assert.True(result._trackingCat.Options.Any(i => i.Name == options.Last().Name));
        }

        public async Task Then_Category_Has_Options()
        {
            var result = await Api.TrackingCategories.FindAsync(Category1.Id);

            Assert.True(result != null);
            Assert.True(result.Options.Count() == 2);

            //            Assert.True(result._trackingCat.Options.Any(i => i.Name == options.FirstOrDefault().Name));
            //            Assert.True(result._trackingCat.Options.Any(i => i.Name == options.Last().Name));
        }

        public async Task Given_GetAll()
        {
            _listresult = (await Api.TrackingCategories.FindAsync()).ToList();
        }

        public async Task Given_GetAll_with_Archived()
        {
            var api = Api.TrackingCategories.IncludeArchived(true);

            _listresult = (await api.FindAsync()).ToList();
        }

        public void Then_Archieved_Tracking_Category_is_in_list()
        {
            var actualTracking = _listresult.SingleOrDefault(i => i.Id == Category1.Id);

            Assert.IsTrue(actualTracking != null);
        }

        public void List_contains_the_two_Tracking_Category()
        {
            Assert.IsTrue(_listresult.First().Name == Category1.Name);
            Assert.IsTrue(_listresult.Last().Name == Category2.Name);
        }
    }
}
