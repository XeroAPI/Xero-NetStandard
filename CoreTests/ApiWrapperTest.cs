using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core;
using Xero.Api.Core.Model;
using Xero.Api.Infrastructure.Applications.Private;

namespace CoreTests
{
    public class ApiWrapperTest
    {
        private IXeroCoreApi _api;

        protected Account BankAccount { get; set; }
        protected Account Account { get; set; }
        
        protected IXeroCoreApi Api
        {
            get { return _api ?? (_api = CreateCoreApi()); }
        }

        private static IXeroCoreApi CreateCoreApi()
        {
            return new Core();
        }

        protected async Task SetUp()
        {
            BankAccount = await Given_a_bank_account();
            Account = await Given_an_account();
        }

        protected async Task<Account> Given_a_bank_account()
        {
            return (await Api.Accounts.Where("Type == \"BANK\"").FindAsync()).First();
        }

        protected async Task<Account> Given_an_account()
        {
            return (await Api.Accounts.Where("Type != \"BANK\"").FindAsync()).First();
        }
    }
}
