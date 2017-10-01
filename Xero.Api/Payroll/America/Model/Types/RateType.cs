using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "")]
    public enum RateType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "MULTIPLE")]
        Multiple,
        [EnumMember(Value = "FIXEDAMOUNT")]
        FixedAmount,
        [EnumMember(Value = "RATEPERUNIT")]
        RatePerUnit
    }
}