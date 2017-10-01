using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Status
{
    [DataContract(Namespace = "")]
    public enum EmploymentStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "TERMINATED")]
        Terminated
    }
}