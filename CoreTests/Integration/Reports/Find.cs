using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CoreTests.Integration.Reports
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {
        [Test]
        public async Task find_all()
        {
            var reports = await Api.Reports.FindAsync();
            Assert.IsNotNull(reports);
        }

        [Test]
        public async Task find_balance_sheet_report()
        {
            var reports = await Api.Reports.BalanceSheetAsync(DateTime.Now);
            Assert.IsNotNull(reports);
        }

        [Test]
        public async Task find_profit_loss_report()
        {
            var reports = await Api.Reports.ProfitAndLossAsync(DateTime.Now);
            Assert.IsNotNull(reports);
        }

        [Test]
        public async Task find_budget_summary_report()
        {
            var reports = await Api.Reports.BudgetSummaryAsync(DateTime.Now);
            Assert.IsNotNull(reports);
        }
        
        [Test]
        public async Task find_bank_summary_report()
        {
            var reports = await Api.Reports.BankSummaryAsync();
            Assert.IsNotNull(reports);
        }

        [Test]
        public async Task find_executive_summary_report()
        {
            var reports = await Api.Reports.ExecutiveSummaryAsync(DateTime.Now);
            Assert.IsNotNull(reports);
        }

        [Test]
        public async Task find_trial_balance_report()
        {
            var reports = await Api.Reports.TrailBalanceAsync(DateTime.Now);
            Assert.IsNotNull(reports);
        }
    }
}