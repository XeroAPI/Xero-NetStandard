using NUnit.Framework;

namespace CoreTests.Unit
{
    public class SummarizeErrors : ApiWrapperTest
    {
        [SetUp]
        public void Setup()
        {
            Api.Invoices.ClearQueryString();
        }

        [Test]
        public void summarize_errors_on_by_default()
        {
            const string expected = "unitdp=4&page=1";

            var query = Api.Invoices
                .QueryString;

            Assert.AreEqual(expected, query);
        }

        [Test]
        public void summarize_errors_off()
        {
            const string expected = "unitdp=4&page=1&summarizeErrors=false";

            var query = Api.Invoices.SummarizeErrors(false)
                .QueryString;

            Assert.AreEqual(expected, query);
        }
    }
}
