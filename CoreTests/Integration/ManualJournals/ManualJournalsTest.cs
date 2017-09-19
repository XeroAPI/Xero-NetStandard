using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration.ManualJournals
{
    public class ManualJournalsTest : ApiWrapperTest
    {
        protected Account Sales { get; private set; }
        protected Account Revenue { get; private set; }
        
        protected void ManualJournalsSetUp()
        {
            SetUp();
            Sales = Given_an_account();
            Revenue = Given_an_account(AccountType.Revenue);
        }

        private Account Given_an_account(AccountType type = AccountType.Sales)
        {
            return Api.Accounts
                .Where(string.Format("Type == \"{0}\" AND Status == \"ACTIVE\"", type.ToString().ToUpper()))
                .Find()
                .FirstOrDefault() ??

                Api.Create(new Account
                {
                    Name = Random.GetRandomString(20),
                    Code = Random.GetRandomString(10),
                    Type = type
                });
        }

        protected ManualJournal Given_a_manual_journal(string narration, decimal amount)
        {
            return Api.Create(new ManualJournal
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