using System;
using NUnit.Framework;

namespace CoreTests.Integration.Reports
{
    [TestFixture]
    public class Find : ApiWrapperTest
    {

        [Test]
        public void find_all()
        {
            var reports = Api.Reports.FindAsync();
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_gst_report()
        {
            var reports = Api.Reports.FindAsync("BalanceSheet");
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_PL_report()
        {
            var reports = Api.Reports.ProfitAndLossAsync(DateTime.Now.AddDays(-50));
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_BudgetSummary_report()
        {
            var reports = Api.Reports.BudgetSummaryAsync(DateTime.Now.AddDays(-50));
            Assert.IsNotNull(reports);
        }
    }
}
