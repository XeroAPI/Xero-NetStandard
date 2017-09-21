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

        public WorkLocationsEndpoint WorkLocations { get; private set; }
        public PayStubsEndpoint PayStubs { get; private set; }
        public PaySchedulesEndpoint PaySchedules { get; private set; }
        public EmployeesEndpoint Employees { get; private set; }
        public PayRunsEndpoint PayRuns { get; private set; }
        public TimesheetsEndpoint Timesheets { get; private set; }
        public SettingsEndpoint Settings { get; private set; }

        private void Connect()
        {
            WorkLocations = new WorkLocationsEndpoint(Client);
            PayStubs = new PayStubsEndpoint(Client);
            PaySchedules = new PaySchedulesEndpoint(Client);
            Employees = new EmployeesEndpoint(Client);
            PayRuns = new PayRunsEndpoint(Client);
            Settings = new SettingsEndpoint(Client);
            Timesheets = new TimesheetsEndpoint(Client);            
        }

        // Note: Due to the immutability of endpoints, If you want to use filtering etc you will need to make requests via the endpoints themselves, not using the sugar methods below

        public async Task<IEnumerable<PaySchedule>> CreateAsync(IEnumerable<PaySchedule> items)
        {
            return await PaySchedules.CreateAsync(items);
        }

        public async Task<IEnumerable<WorkLocation>> CreateAsync(IEnumerable<WorkLocation> items)
        {
            return await WorkLocations.CreateAsync(items);
        }

        public async Task<IEnumerable<PayStub>> CreateAsync(IEnumerable<PayStub> items)
        {
            return await PayStubs.CreateAsync(items);
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

        public async Task<PaySchedule> CreateAsync(PaySchedule item)
        {
            return await PaySchedules.CreateAsync(item);
        }

        public async Task<WorkLocation> CreateAsync(WorkLocation item)
        {
            return await WorkLocations.CreateAsync(item);
        }

        public async Task<PayStub> CreateAsync(PayStub item)
        {
            return await PayStubs.CreateAsync(item);
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

        public async Task<IEnumerable<PaySchedule>> UpdateAsync(IEnumerable<PaySchedule> items)
        {
            return await PaySchedules.UpdateAsync(items);
        }

        public async Task<IEnumerable<WorkLocation>> UpdateAsync(IEnumerable<WorkLocation> items)
        {
            return await WorkLocations.UpdateAsync(items);
        }

        public async Task<IEnumerable<PayStub>> UpdateAsync(IEnumerable<PayStub> items)
        {
            return await PayStubs.UpdateAsync(items);
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

        public async Task<PaySchedule> UpdateAsync(PaySchedule item)
        {
            return await PaySchedules.UpdateAsync(item);
        }

        public async Task<WorkLocation> UpdateAsync(WorkLocation item)
        {
            return await WorkLocations.UpdateAsync(item);
        }

        public async Task<PayStub> UpdateAsync(PayStub item)
        {
            return await PayStubs.UpdateAsync(item);
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
    }
}