using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum State
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACT")]
        AustralianCapitalTerritory,
        [EnumMember(Value = "NSW")]
        NewSouthWales,
        [EnumMember(Value = "NT")]
        NorthernTerritory,
        [EnumMember(Value = "QLD")]
        Queensland,
        [EnumMember(Value = "SA")]
        SouthAustralia,
        [EnumMember(Value = "TAS")]
        Tasmania,
        [EnumMember(Value = "VIC")]
        Victoria,
        [EnumMember(Value = "WA")]
        WesternAustralia
    }
}