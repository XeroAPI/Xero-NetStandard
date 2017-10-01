using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Status
{
    [DataContract(Namespace =  "")]
    public enum LeavePeriodStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "PROCESSED")]
        Processed,
        [EnumMember(Value = "SCHEDULED")]
        Scheduled
    }
}