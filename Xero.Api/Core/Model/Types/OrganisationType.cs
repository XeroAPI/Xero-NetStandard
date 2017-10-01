using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OrganisationType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "COMPANY")]
        Company,
        [EnumMember(Value = "CHARITY")]
        Charity,
        [EnumMember(Value = "CLUBSOCIETY")]
        ClubSociety,
        [EnumMember(Value = "PARTNERSHIP")]
        Partnership,
        [EnumMember(Value = "PERSON")]
        Person,
        [EnumMember(Value = "SOLETRADER")]
        SoleTrader,
        [EnumMember(Value = "TRUST")]
        Trust
    }
}