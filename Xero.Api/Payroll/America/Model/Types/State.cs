using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    [DataContract(Namespace = "")]
    public enum State
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "AL")]
        Alabama,
        [EnumMember(Value = "AK")]
        Alaska,
        [EnumMember(Value = "AZ")]
        Arizona,
        [EnumMember(Value = "AR")]
        Arkansas,
        [EnumMember(Value = "CA")]
        California,
        [EnumMember(Value = "CO")]
        Colorado,
        [EnumMember(Value = "CT")]
        Connecticut,
        [EnumMember(Value = "DE")]
        Delaware,
        [EnumMember(Value = "DC")]
        DistrictOfColumbia,
        [EnumMember(Value = "FL")]
        Florida,
        [EnumMember(Value = "GA")]
        Georgia,
        [EnumMember(Value = "HI")]
        Hawaii,
        [EnumMember(Value = "ID")]
        Idaho,
        [EnumMember(Value = "IL")]
        Illinois,
        [EnumMember(Value = "IN")]
        Indiana,
        [EnumMember(Value = "IA")]
        Iowa,
        [EnumMember(Value = "KS")]
        Kansas,
        [EnumMember(Value = "KY")]
        Kentucky,
        [EnumMember(Value = "LA")]
        Louisiana,
        [EnumMember(Value = "ME")]
        Maine,
        [EnumMember(Value = "MD")]
        Maryland,
        [EnumMember(Value = "MA")]
        Massachusetts,
        [EnumMember(Value = "MI")]
        Michigan,
        [EnumMember(Value = "MN")]
        Minnesota,
        [EnumMember(Value = "MS")]
        Mississippi,
        [EnumMember(Value = "MO")]
        Missouri,
        [EnumMember(Value = "MT")]
        Montana,
        [EnumMember(Value = "NE")]
        Nebraska,
        [EnumMember(Value = "NV")]
        Nevada,
        [EnumMember(Value = "NH")]
        NewHampshire,
        [EnumMember(Value = "NJ")]
        NewJersey,
        [EnumMember(Value = "NM")]
        NewMexico,
        [EnumMember(Value = "NY")]
        NewYork,
        [EnumMember(Value = "NC")]
        NorthCarolina,
        [EnumMember(Value = "ND")]
        NorthDakota,
        [EnumMember(Value = "OH")]
        Ohio,
        [EnumMember(Value = "OK")]
        Oklahoma,
        [EnumMember(Value = "OR")]
        Oregon,
        [EnumMember(Value = "PA")]
        Pennsylvania,
        [EnumMember(Value = "RI")]
        RhodeIsland,
        [EnumMember(Value = "SC")]
        SouthCarolina,
        [EnumMember(Value = "SD")]
        SouthDakota,
        [EnumMember(Value = "TN")]
        Tennessee,
        [EnumMember(Value = "TX")]
        Texas,
        [EnumMember(Value = "UT")]
        Utah,
        [EnumMember(Value = "VT")]
        Vermont,
        [EnumMember(Value = "VA")]
        Virginia,
        [EnumMember(Value = "WA")]
        Washington,
        [EnumMember(Value = "WV")]
        WestVirginia,
        [EnumMember(Value = "WI")]
        Wisconsin,
        [EnumMember(Value = "WY")]
        Wyoming
    }
}