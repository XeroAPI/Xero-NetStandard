using Xero.Api.Payroll;

namespace PayrollTests.US
{
    public class ApiWrapperTest
    {
        private AmericanPayroll _api;

        protected AmericanPayroll Api
        {
            get { return _api ?? (_api = CreateApi()); }
        }

        private static AmericanPayroll CreateApi()
        {
            return new Xero.Api.Infrastructure.Applications.Private.AmericanPayroll
            {
                UserAgent = "Xero API - Integration tests (US Payroll)"
            };
        }
    }
}
