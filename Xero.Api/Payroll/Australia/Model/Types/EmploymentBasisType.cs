using System.Runtime.Serialization;

namespace Xero.Api.Payroll.Australia.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EmploymentBasisType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "FULLTIME")]
        FullTime,
        [EnumMember(Value = "PARTTIME")]
        PartTime,
        [EnumMember(Value = "CASUAL")]
        Casual,
        [EnumMember(Value = "LABOURHIRE")]
        LabouRHire,
        [EnumMember(Value = "SUPERINCOMESTREAM")]
        SuperIncomeStream
    }
}