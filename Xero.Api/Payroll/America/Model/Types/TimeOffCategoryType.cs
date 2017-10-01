using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "", Name = "TimeOffCategory")]
    public enum TimeOffCategoryType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "UNPAIDTIMEOFF")]
        Unpaid,
        [EnumMember(Value = "PAIDTIMEOFF")]
        Paid
    }
}