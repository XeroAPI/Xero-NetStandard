using System.Collections.Generic;
using System.Threading.Tasks;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Infrastructure.RateLimiter;
using Xero.Api.Payroll.America.Endpoints;
using Xero.Api.Payroll.America.Model;
using Xero.Api.Payroll.Common;
using PayRun = Xero.Api.Payroll.America.Model.PayRun;

namespace Xero.Api.Payroll
{
    public class AmericanPayroll : PayrollApi
    {
        public AmericanPayroll(IAuthenticator auth, IUser user = null, IRateLimiter rateLimiter = null)
            : base(auth, user, rateLimiter)
        {
            Connect();
        }

        public AmericanPayroll(string baseUrl, IAuthenticator auth, IUser user = null, IConsumer consumer = null, IRateLimiter rateLimiter = null)
            : base(baseUrl, auth, user, consumer, rateLimiter)
        {
            Connect();
        }


        public WorkLocationsEndpoint WorkLocations { get; private set; }
        public PayItemsEndpoint PayItems { get; private set; }
        public PayStubsEndpoint PayStubs { get; private set; }
        public PaySchedulesEndpoint PaySchedules { get; private set; }
        public EmployeesEndpoint Employees { get; private set; }
        public PayRunsEndpoint PayRuns { get; private set; }
        public TimesheetsEndpoint Timesheets { get; private set; }
        public SettingsEndpoint Settings { get; private set; }

        private void Connect()
        {
            WorkLocations = new WorkLocationsEndpoint(Client);
            PayItems = new PayItemsEndpoint(Client);
            PayStubs = new PayStubsEndpoint(Client);
            PaySchedules = new PaySchedulesEndpoint(Client);
            Employees = new EmployeesEndpoint(Client);
            PayRuns = new PayRunsEndpoint(Client);
            Settings = new SettingsEndpoint(Client);
            Timesheets = new TimesheetsEndpoint(Client);
        }

        // Note: Due to the immutability of endpoints, If you want to use filtering etc you will need to make requests via the endpoints themselves, not using the sugar methods below

        public Task<IEnumerable<PaySchedule>> CreateAsync(IEnumerable<PaySchedule> items)
        {
            return PaySchedules.CreateAsync(items);
        }

        public Task<IEnumerable<WorkLocation>> CreateAsync(IEnumerable<WorkLocation> items)
        {
            return WorkLocations.CreateAsync(items);
        }

        public Task<IEnumerable<PayStub>> CreateAsync(IEnumerable<PayStub> items)
        {
            return PayStubs.CreateAsync(items);
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

        public Task<PaySchedule> CreateAsync(PaySchedule item)
        {
            return PaySchedules.CreateAsync(item);
        }

        public Task<WorkLocation> CreateAsync(WorkLocation item)
        {
            return WorkLocations.CreateAsync(item);
        }

        public Task<PayStub> CreateAsync(PayStub item)
        {
            return PayStubs.CreateAsync(item);
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

        public Task<IEnumerable<PaySchedule>> UpdateAsync(IEnumerable<PaySchedule> items)
        {
            return PaySchedules.UpdateAsync(items);
        }

        public Task<IEnumerable<WorkLocation>> UpdateAsync(IEnumerable<WorkLocation> items)
        {
            return WorkLocations.UpdateAsync(items);
        }

        public Task<IEnumerable<PayStub>> UpdateAsync(IEnumerable<PayStub> items)
        {
            return PayStubs.UpdateAsync(items);
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

        public Task<PaySchedule> UpdateAsync(PaySchedule item)
        {
            return PaySchedules.UpdateAsync(item);
        }

        public Task<WorkLocation> UpdateAsync(WorkLocation item)
        {
            return WorkLocations.UpdateAsync(item);
        }

        public Task<PayStub> UpdateAsync(PayStub item)
        {
            return PayStubs.UpdateAsync(item);
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
    }
}