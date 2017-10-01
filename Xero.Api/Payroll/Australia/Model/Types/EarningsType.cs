using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EarningsType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "FIXED")]
        Fixed,
        [EnumMember(Value = "ORDINARYTIMEEARNINGS")]
        OrdinaryTimeEarnings,
        [EnumMember(Value = "OVERTIMEEARNINGS")]
        OverTimeEarnings,
        [EnumMember(Value = "ALLOWANCE")]
        Allowance,
        [EnumMember(Value = "LUMPSUMD")]
        LumpSumD
    }
}