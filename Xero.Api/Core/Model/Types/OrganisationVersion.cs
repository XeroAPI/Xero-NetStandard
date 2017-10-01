using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum OrganisationVersion
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "AU")]
        Australia,
        [EnumMember(Value = "NZ")]
        NewZealand,
        [EnumMember(Value = "GLOBAL")]
        Global,
        [EnumMember(Value = "UK")]
        UnitedKingdom,
        [EnumMember(Value = "US")]
        UnitedStates,
        [EnumMember(Value = "AUONRAMP")]
        AustraliaSignUp,
        [EnumMember(Value = "NZONRAMP")]
        NewZealandSignUp,
        [EnumMember(Value = "GLOBALONRAMP")]
        GlobalSignUp,
        [EnumMember(Value = "UKONRAMP")]
        UnitedKingdomSignUp,
        [EnumMember(Value = "USONRAMP")]
        UnitedStatesSignUp,
    }
}