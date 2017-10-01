using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model.Types
{
    // I'm sure there are more but I found these in the documentation
    [DataContract(Namespace = "", Name = "BenefitCategory")]    
    public enum BenefitCategoryType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "SECTION125PLAN")]
        Section125Plan
    }
}