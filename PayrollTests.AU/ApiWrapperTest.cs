using Xero.Api.Payroll;

namespace PayrollTests.AU
{
    public class ApiWrapperTest
    {
        private AustralianPayroll _api;

        protected AustralianPayroll Api
        {
            get { return _api ?? (_api = CreateApi()); }
        }

        private static AustralianPayroll CreateApi()
        {
            return new Xero.Api.Infrastructure.Applications.Private.AustralianPayroll();
        }
    }
}
