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

        public Task<IEnumerable<LeaveApplication>> CreateAsync(IEnumerable<LeaveApplication> items)
        {
            return LeaveApplications.CreateAsync(items);
        }

        public Task<IEnumerable<Payslip>> CreateAsync(IEnumerable<Payslip> items)
        {
            return Payslips.CreateAsync(items);
        }

        public Task<IEnumerable<SuperFund>> CreateAsync(IEnumerable<SuperFund> items)
        {
            return SuperFunds.CreateAsync(items);
        }

        public Task<IEnumerable<Employee>> CreateAsync(IEnumerable<Employee> items)
        {
            return Employees.CreateAsync(items);
        }

        public Task<IEnumerable<PayRun>> CreateAsync(IEnumerable<PayRun> items)
        {
            return PayRuns.CreateAsync(items);
        }

        public Task<IEnumerable<Timesheet>> CreateAsync(IEnumerable<Timesheet> items)
        {
            return Timesheets.CreateAsync(items);
        }

        public Task<IEnumerable<PayrollCalendar>> CreateAsync(IEnumerable<PayrollCalendar> items)
        {
            return PayrollCalendars.CreateAsync(items);
        }

        public Task<LeaveApplication> CreateAsync(LeaveApplication item)
        {
            return LeaveApplications.CreateAsync(item);
        }

        public Task<Payslip> CreateAsync(Payslip item)
        {
            return Payslips.CreateAsync(item);
        }

        public Task<SuperFund> CreateAsync(SuperFund item)
        {
            return SuperFunds.CreateAsync(item);
        }

        public Task<Employee> CreateAsync(Employee item)
        {
            return Employees.CreateAsync(item);
        }

        public Task<PayRun> CreateAsync(PayRun item)
        {
            return PayRuns.CreateAsync(item);
        }

        public Task<Timesheet> CreateAsync(Timesheet item)
        {
            return Timesheets.CreateAsync(item);
        }

        public Task<PayItems> CreateAsync(PayItems item)
        {
            return PayItems.CreateAsync(item);
        }

        public Task<PayrollCalendar> CreateAsync(PayrollCalendar item)
        {
            return PayrollCalendars.CreateAsync(item);
        }

        public Task<IEnumerable<LeaveApplication>> UpdateAsync(IEnumerable<LeaveApplication> items)
        {
            return LeaveApplications.UpdateAsync(items);
        }

        public Task<IEnumerable<Payslip>> UpdateAsync(IEnumerable<Payslip> items)
        {
            return Payslips.UpdateAsync(items);
        }

        public Task<IEnumerable<SuperFund>> UpdateAsync(IEnumerable<SuperFund> items)
        {
            return SuperFunds.UpdateAsync(items);
        }

        public Task<IEnumerable<Employee>> UpdateAsync(IEnumerable<Employee> items)
        {
            return Employees.UpdateAsync(items);
        }

        public Task<IEnumerable<PayRun>> UpdateAsync(IEnumerable<PayRun> items)
        {
            return PayRuns.UpdateAsync(items);
        }

        public Task<IEnumerable<Timesheet>> UpdateAsync(IEnumerable<Timesheet> items)
        {
            return Timesheets.UpdateAsync(items);
        }

        public Task<IEnumerable<PayrollCalendar>> UpdateAsync(IEnumerable<PayrollCalendar> items)
        {
            return PayrollCalendars.UpdateAsync(items);
        }

        public Task<LeaveApplication> UpdateAsync(LeaveApplication item)
        {
            return LeaveApplications.UpdateAsync(item);
        }

        public Task<Payslip> UpdateAsync(Payslip item)
        {
            return Payslips.UpdateAsync(item);
        }

        public Task<SuperFund> UpdateAsync(SuperFund item)
        {
            return SuperFunds.UpdateAsync(item);
        }

        public Task<Employee> UpdateAsync(Employee item)
        {
            return Employees.UpdateAsync(item);
        }

        public Task<PayRun> UpdateAsync(PayRun item)
        {
            return PayRuns.UpdateAsync(item);
        }

        public Task<Timesheet> UpdateAsync(Timesheet item)
        {
            return Timesheets.UpdateAsync(item);
        }

        public Task<PayItems> UpdateAsync(PayItems item)
        {
            return PayItems.UpdateAsync(item);
        }

        public Task<PayrollCalendar> UpdateAsync(PayrollCalendar item)
        {
            return PayrollCalendars.UpdateAsync(item);
        }
    }
}