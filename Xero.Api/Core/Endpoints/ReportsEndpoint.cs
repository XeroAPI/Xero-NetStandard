using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Model.Reports;
using Xero.Api.Core.Model.Types;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IReportsEndpoint : IXeroReadEndpoint<ReportsEndpoint, Report, ReportsResponse>
    {
        Task<Report> GetPublishedReportAsync(string id);
        Task<Report> GetPublishedReportAsync(Guid id);
        Task<IEnumerable<string>> PublishedAsync();
        IEnumerable<string> Named();
        Task<Report> AgedPayablesAsync(Guid contact, DateTime? date = null, DateTime? from = null, DateTime? to = null);
        Task<Report> AgedReceivablesAsync(Guid contact, DateTime? date = null, DateTime? from = null, DateTime? to = null);
        Task<Report> TenNinetyNineAsync(DateTime? year);
        Task<Report> BalanceSheetAsync(DateTime date, Guid? tracking1 = null, Guid? tracking2 = null,
            bool standardLayout = false);
        Task<Report> BankStatementAsync(Guid account, DateTime? from = null, DateTime? to = null);
        Task<Report> BankSummaryAsync(DateTime? from = null, DateTime? to = null);
        Task<Report> BudgetSummaryAsync(DateTime? date = null, int? periods = null, BudgetSummaryTimeframeType? timeFrame = null);
        Task<Report> ExecutiveSummaryAsync(DateTime? date = null);
        Task<Report> ProfitAndLossAsync(DateTime? date, DateTime? from = null, DateTime? to = null,
            Guid? trackingCategory = null, Guid? trackingOption = null, Guid? trackingCategory2 = null,
            Guid? trackingOption2 = null, bool? standardLayout = null);
        Task<Report> TrailBalanceAsync(DateTime? date = null, bool? paymentsOnly = null);
    }

    public class ReportsEndpoint : XeroReadEndpoint<ReportsEndpoint, Report, ReportsResponse>, IReportsEndpoint
    {
        public ReportsEndpoint(XeroHttpClient client)
            : base(client, "/api.xro/2.0/Reports")
        {
        }

        public async Task<Report> GetPublishedReportAsync(string id)
        {
            return await FindAsync(id);
        }

        public async Task<Report> GetPublishedReportAsync(Guid id)
        {
            return await FindAsync(id);
        }

        public async Task<IEnumerable<string>> PublishedAsync()
        {
            return (await FindAsync()).Select(r => r.ReportID);
        }

        public IEnumerable<string> Named()
        {
            return Enum.GetNames(typeof(NamedReportType));
        }

        public async Task<Report> TenNinetyNineAsync(DateTime? year)
        {
            var parameters = new NameValueCollection();

            parameters.AddYear("reportYear", year);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.TenNinetyNine.ToString());
        }

        public async Task<Report> AgedPayablesAsync(Guid contact, DateTime? date = null, DateTime? from = null, DateTime? to = null)
        {
            var parameters = GetAgedParameters(contact, date, from, to);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.AgedPayablesByContact.ToString());
        }

        public async Task<Report> AgedReceivablesAsync(Guid contact, DateTime? date = null, DateTime? from = null, DateTime? to = null)
        {
            var parameters = GetAgedParameters(contact, date, from, to);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.AgedReceivablesByContact.ToString());
        }

        public async Task<Report> BalanceSheetAsync(DateTime date, Guid? tracking1 = null, Guid? tracking2 = null,
            bool standardLayout = false)
        {
            var parameters = new NameValueCollection();

            parameters.Add("date", date);
            parameters.Add("trackingOptionID1", tracking1);
            parameters.Add("trackingOptionID2", tracking2);
            parameters.Add("standardLayout", standardLayout);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.BalanceSheet.ToString());
        }

        public async Task<Report> BankStatementAsync(Guid account, DateTime? from = null, DateTime? to = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("bankAccountID", account);
            parameters.Add("fromDate", from);
            parameters.Add("toDate", to);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.BankStatement.ToString());
        }

        public async Task<Report> BankSummaryAsync(DateTime? from = null, DateTime? to = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("fromDate", from);
            parameters.Add("toDate", to);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.BankSummary.ToString());
        }

        public async Task<Report> BudgetSummaryAsync(DateTime? date = null, int? periods = null, BudgetSummaryTimeframeType? timeFrame = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("date", date);
            parameters.Add("periods", periods);
            parameters.Add("timeframe", (int?)timeFrame);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.BudgetSummary.ToString());
        }

        public async Task<Report> ExecutiveSummaryAsync(DateTime? date = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("date", date);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.ExecutiveSummary.ToString());
        }

        public async Task<Report> ProfitAndLossAsync(DateTime? date, DateTime? from = null, DateTime? to = null,
            Guid? trackingCategory = null, Guid? trackingOption = null, Guid? trackingCategory2 = null,
            Guid? trackingOption2 = null, bool? standardLayout = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("date", date);
            parameters.Add("fromDate", from);
            parameters.Add("toDate", to);
            parameters.Add("trackingCategoryID", trackingCategory);
            parameters.Add("trackingOptionID", trackingOption);
            parameters.Add("trackingCategoryID2", trackingCategory2);
            parameters.Add("trackingOptionID2", trackingOption2);
            parameters.Add("standardLayout", standardLayout);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.ProfitAndLoss.ToString());
        }

        public async Task<Report> TrailBalanceAsync(DateTime? date = null, bool? paymentsOnly = null)
        {
            var parameters = new NameValueCollection();

            parameters.Add("date", date);
            parameters.Add("paymentsOnly", paymentsOnly);

            var endpoint = AddParameters(parameters);

            return await endpoint.FindAsync(NamedReportType.TrialBalance.ToString());
        }

        private NameValueCollection GetAgedParameters(Guid contact, DateTime? date, DateTime? from, DateTime? to)
        {
            var parameters = new NameValueCollection
            {
                {
                    "contactID", contact.ToString("D")
                }
            };

            parameters.Add("date", date);
            parameters.Add("fromDate", from);
            parameters.Add("toDate", to);

            return parameters;
        }
    }

    internal static class Extensions
    {
        public static string ToReportDate(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        public static void AddYear(this NameValueCollection collection, string name, DateTime? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.Year);
            }
        }

        public static void Add(this NameValueCollection collection, string name, DateTime? value)
        {
            if (value.HasValue)
            {
                collection.Add(name, value.Value.ToReportDate());
            }
        }
    }
}
