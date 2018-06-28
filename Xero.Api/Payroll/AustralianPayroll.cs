using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Payroll.Australia.Endpoints;
using Xero.Api.Payroll.Australia.Model;
using Xero.Api.Payroll.Common;
using PayRun = Xero.Api.Payroll.Australia.Model.PayRun;

namespace Xero.Api.Payroll
{
    public class AustralianPayroll : PayrollApi
    {
        public AustralianPayroll(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : base(auth, user, rateLimiter)
        {
            Connect();
        }

        public AustralianPayroll(string baseUrl, IAuthenticator auth, IUser user = null, IConsumer consumer = null, IRateLimiter rateLimiter = null)
            : base(baseUrl, auth, user, consumer, rateLimiter)
        {
            Connect();
        }

        public SuperFundsEndpoint SuperFunds { get; set; }
        public SuperFundProductsEndpoint SuperFundProducts { get; set; }
        public LeaveApplicationsEndpoint LeaveApplications { get; set; }
        public PayslipsEndpoint Payslips { get; private set; }

        public EmployeesEndpoint Employees { get; private set; }
        public PayRunsEndpoint PayRuns { get; private set; }
        public TimesheetsEndpoint Timesheets { get; private set; }

        public PayItemsEndpoint PayItems { get; private set; }
        public PayrollCalendarsEndpoint PayrollCalendars { get; private set; }
        public SettingsEndpoint Settings { get; private set; }

        private void Connect()
        {
            LeaveApplications = new LeaveApplicationsEndpoint(Client);
            SuperFundProducts = new SuperFundProductsEndpoint(Client);
            SuperFunds = new SuperFundsEndpoint(Client);
            Payslips = new PayslipsEndpoint(Client);

            Employees = new EmployeesEndpoint(Client);
            PayRuns = new PayRunsEndpoint(Client);
            Timesheets = new TimesheetsEndpoint(Client);
            PayItems = new PayItemsEndpoint(Client);
            PayrollCalendars = new PayrollCalendarsEndpoint(Client);
            Settings = new SettingsEndpoint(Client);
        }

        // Note: Due to the immutability of endpoints, If you want to use filtering etc you will need to make requests via the endpoints themselves, not using the sugar methods below

        public async Task<IEnumerable<LeaveApplication>> CreateAsync(IEnumerable<LeaveApplication> items)
        {
            return await LeaveApplications.CreateAsync(items);
        }

        public async Task<IEnumerable<Payslip>> CreateAsync(IEnumerable<Payslip> items)
        {
            return await Payslips.CreateAsync(items);
        }

        public async Task<IEnumerable<SuperFund>> CreateAsync(IEnumerable<SuperFund> items)
        {
            return await SuperFunds.CreateAsync(items);
        }

        public async Task<IEnumerable<Employee>> CreateAsync(IEnumerable<Employee> items)
        {
            return await Employees.CreateAsync(items);
        }

        public async Task<IEnumerable<PayRun>> CreateAsync(IEnumerable<PayRun> items)
        {
            return await PayRuns.CreateAsync(items);
        }

        public async Task<IEnumerable<Timesheet>> CreateAsync(IEnumerable<Timesheet> items)
        {
            return await Timesheets.CreateAsync(items);
        }

        public async Task<IEnumerable<PayrollCalendar>> CreateAsync(IEnumerable<PayrollCalendar> items)
        {
            return await PayrollCalendars.CreateAsync(items);
        }

        public async Task<LeaveApplication> CreateAsync(LeaveApplication item)
        {
            return await LeaveApplications.CreateAsync(item);
        }

        public async Task<Payslip> CreateAsync(Payslip item)
        {
            return await Payslips.CreateAsync(item);
        }

        public async Task<SuperFund> CreateAsync(SuperFund item)
        {
            return await SuperFunds.CreateAsync(item);
        }

        public async Task<Employee> CreateAsync(Employee item)
        {
            return await Employees.CreateAsync(item);
        }

        public async Task<PayRun> CreateAsync(PayRun item)
        {
            return await PayRuns.CreateAsync(item);
        }

        public async Task<Timesheet> CreateAsync(Timesheet item)
        {
            return await Timesheets.CreateAsync(item);
        }

        public async Task<PayItems> CreateAsync(PayItems item)
        {
            return await PayItems.CreateAsync(item);
        }

        public async Task<PayrollCalendar> CreateAsync(PayrollCalendar item)
        {
            return await PayrollCalendars.CreateAsync(item);
        }

        public async Task<IEnumerable<LeaveApplication>> UpdateAsync(IEnumerable<LeaveApplication> items)
        {
            return await LeaveApplications.UpdateAsync(items);
        }

        public async Task<IEnumerable<Payslip>> UpdateAsync(IEnumerable<Payslip> items)
        {
            return await Payslips.UpdateAsync(items);
        }

        public async Task<IEnumerable<SuperFund>> UpdateAsync(IEnumerable<SuperFund> items)
        {
            return await SuperFunds.UpdateAsync(items);
        }

        public async Task<IEnumerable<Employee>> UpdateAsync(IEnumerable<Employee> items)
        {
            return await Employees.UpdateAsync(items);
        }

        public async Task<IEnumerable<PayRun>> UpdateAsync(IEnumerable<PayRun> items)
        {
            return await PayRuns.UpdateAsync(items);
        }

        public async Task<IEnumerable<Timesheet>> UpdateAsync(IEnumerable<Timesheet> items)
        {
            return await Timesheets.UpdateAsync(items);
        }

        public async Task<IEnumerable<PayrollCalendar>> UpdateAsync(IEnumerable<PayrollCalendar> items)
        {
            return await PayrollCalendars.UpdateAsync(items);
        }

        public async Task<LeaveApplication> UpdateAsync(LeaveApplication item)
        {
            return await LeaveApplications.UpdateAsync(item);
        }

        public async Task<Payslip> UpdateAsync(Payslip item)
        {
            return await Payslips.UpdateAsync(item);
        }

        public async Task<SuperFund> UpdateAsync(SuperFund item)
        {
            return await SuperFunds.UpdateAsync(item);
        }

        public async Task<Employee> UpdateAsync(Employee item)
        {
            return await Employees.UpdateAsync(item);
        }

        public async Task<PayRun> UpdateAsync(PayRun item)
        {
            return await PayRuns.UpdateAsync(item);
        }

        public async Task<Timesheet> UpdateAsync(Timesheet item)
        {
            return await Timesheets.UpdateAsync(item);
        }

        public async Task<PayItems> UpdateAsync(PayItems item)
        {
            return await PayItems.UpdateAsync(item);
        }

        public async Task<PayrollCalendar> UpdateAsync(PayrollCalendar item)
        {
            return await PayrollCalendars.UpdateAsync(item);
        }
    }
}