using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.ManualJournals
{
    public class ManualJournalsTest : ApiWrapperTest
    {
        protected Account Sales { get; private set; }
        protected Account Revenue { get; private set; }
        
        protected async Task ManualJournalsSetUp()
        {
            await SetUp();
            Sales = await Given_an_account();
            Revenue = await Given_an_account(AccountType.Revenue);
        }

        private async Task<Account> Given_an_account(AccountType type = AccountType.Sales)
        {
            return (await Api.Accounts
                .Where(string.Format("Type == \"{0}\" AND Status == \"ACTIVE\"", type.ToString().ToUpper()))
                .FindAsync())
                .FirstOrDefault() ??

                await Api.CreateAsync(new Account
                {
                    Name = Random.GetRandomString(20),
                    Code = Random.GetRandomString(10),
                    Type = type
                });
        }

        protected async Task<ManualJournal> Given_a_manual_journal(string narration, decimal amount)
        {
            return await Api.CreateAsync(new ManualJournal
            {
                Date = DateTime.UtcNow.Date,
                Narration = narration,
                Lines = new List<Line>
                {
                    new Line
                    {
                        Amount = amount,
                        AccountCode = Sales.Code
                    },
                    new Line
                    {
                        Amount = -amount,
                        AccountCode = Revenue.Code
                    }
                }
            });
        }
    }
}