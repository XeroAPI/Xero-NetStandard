using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum ReportTaxType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "OUTPUT")]
        Output,
        [EnumMember(Value = "INPUT")]
        Input,
        [EnumMember(Value = "EXEMPTOUTPUT")]
        ExemptOutput,
        [EnumMember(Value = "EXEMPTINPUT")]
        ExemptInput,
        [EnumMember(Value = "INPUTTAXED")]
        InputTaxed,
        [EnumMember(Value = "BASEXCLUDED")]
        BasExcluded,
        [EnumMember(Value = "EXEMPTEXPENSES")]
        ExemptExpenses,
        [EnumMember(Value = "ECOUTPUT")]
        EcOutput,
        [EnumMember(Value = "ECOUTPUTSERVICES")]
        EcOutputServices,
        [EnumMember(Value = "ECINPUT")]
        EcInput,
        [EnumMember(Value = "CAPITALSALESOUTPUT")]
        CapitalSalesOutput,
        [EnumMember(Value = "CAPITALEXPENSESINPUT")]
        CapitalExpensesInput
    }
}