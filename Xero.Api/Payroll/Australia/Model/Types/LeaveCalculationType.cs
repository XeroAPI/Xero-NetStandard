using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum LeaveCalculationType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "FIXEDAMOUNTEACHPERIOD")]
        FixedAmountEachPeriod,
        [EnumMember(Value = "ENTERRATEINPAYTEMPLATE")]
        EnterRateInPayTemplate,
        [EnumMember(Value = "BASEDONORDINARYEARNINGS")]
        BasedOnOrdinaryEarnings
    }
}