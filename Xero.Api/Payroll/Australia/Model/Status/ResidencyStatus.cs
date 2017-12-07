using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Status
{
    [DataContract(Namespace = "")]
    public enum ResidencyStatus
    {
        [EnumMember(Value = "AUSTRALIANRESIDENT")]
        AustralianResident,
        [EnumMember(Value = "FOREIGNRESIDENT")]
        ForeignResident,
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WorkingHoliday,
    }
}
