using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Status
{
    [DataContract(Namespace = "")]
    public enum TimesheetStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "PROCESSED")]
        Processed,
        [EnumMember(Value = "APPROVED")]
        Approved
    }
}