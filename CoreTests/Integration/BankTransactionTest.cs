using System;
using System.Collections.Generic;
using System.Linq;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Types;

namespace CoreTests.Integration
{
    public class BankTransactionTest : ApiWrapperTest
    {

        public BankTransaction NewBankTransaction()
        {
            var newBankTransaction = new BankTransaction
            {
                Type = BankTransactionType.Spend,
                Contact = new Contact { Name = "ABC Bank" },
                LineItems = new List<LineItem>
                    {
                        new LineItem
                        {
                            Description = "Yearly Bank Account Fee",
                            Quantity = 1m,
                            UnitAmount = 20.00m,
                            AccountCode = "404"
                        }
                    },
                BankAccount = new Account { Id = FindBankAccountGuid() }
            };

            return newBankTransaction;
        }



        public Guid FindBankAccountGuid()
        {
            var bankAccount = Api.Accounts.Where("Type == \"BANK\"").Find().FirstOrDefault();

            if (bankAccount != null)
            {
                return bankAccount.Id;
            }

            return Guid.Empty;
        }
    }
}
