using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EmploymentBasisType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "FULLTIME")]
        Fulltime,
        [EnumMember(Value = "PARTTIME")]
        Parttime,
        [EnumMember(Value = "PAIDLEAVE")]
        PaidLeave,
        [EnumMember(Value = "UNPAIDLEAVE ")]
        UnpaidLeave 
    }
}