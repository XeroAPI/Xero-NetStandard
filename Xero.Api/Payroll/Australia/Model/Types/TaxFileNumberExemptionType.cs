using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "", Name = "TFNExemptionType")]
    public enum TaxFileNumberExemptionType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "NOTQUOTED")]
        NotQuoted,
        [EnumMember(Value = "PENDING")]
        Pending,
        [EnumMember(Value = "PENSIONER")]
        Pensioner,
        [EnumMember(Value = "UNDER18")]
        Under18
    }
}