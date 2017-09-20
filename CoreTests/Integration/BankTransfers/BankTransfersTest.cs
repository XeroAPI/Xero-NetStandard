using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;

namespace CoreTests.Integration.BankTransfers
{
    public abstract class BankTransfersTest : ApiWrapperTest
    {

        public async Task<BankTransfer> Given_a_bank_transfer(Decimal amount)
        {
            var accountIds = await get_bankaccount_ids();
   
            var newBankTransfer = new BankTransfer
            {
                FromBankAccount = new Account { Id = accountIds[0] },
                ToBankAccount = new Account { Id = accountIds[1] },
                Amount = amount
            };
            
            return await Api.CreateAsync(newBankTransfer);
        }


        public async Task<IList<Guid>> get_bankaccount_ids()
        {
            return (await Api.Accounts.Where("Type == \"BANK\"")
                .FindAsync())
                .Select(p => p.Id)
                .ToList();
        }
    }
}
