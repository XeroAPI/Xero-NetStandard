using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum SalesTaxPeriodType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "NONE")]
        None,
        [EnumMember(Value = "MONTHLY")]
        Monthly,
        [EnumMember(Value = "TWOMONTHS")]
        TwoMonths,
        [EnumMember(Value = "SIXMONTHS")]
        SixMonths,
        [EnumMember(Value = "QUARTERLY")]
        Quarterly,
        [EnumMember(Value = "QUARTERLY1")]
        QuarterlyOne,
        [EnumMember(Value = "QUARTERLY2")]
        QuarterlyTwo,
        [EnumMember(Value = "QUARTERLY3")]
        QuarterlyThree,
        [EnumMember(Value = "ANNUALLY")]
        Annually        
    }
}