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
            var reports = Api.Reports.Find();
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_gst_report()
        {
            var reports = Api.Reports.Find("BalanceSheet");
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_PL_report()
        {
            var reports = Api.Reports.ProfitAndLoss(DateTime.Now.AddDays(-50));
            Assert.IsNotNull(reports);
        }

        [Test]
        public void find_BudgetSummary_report()
        {
            var reports = Api.Reports.BudgetSummary(DateTime.Now.AddDays(-50));
            Assert.IsNotNull(reports);
        }
    }
}
