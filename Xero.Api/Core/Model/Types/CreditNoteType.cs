using System.Runtime.Serialization;

namespace Xero.Api.Core.Model.Types
{
    [DataContract(Namespace = "")]
    public enum CreditNoteType
    {
        [EnumMember(Value = "UNKNOWN")]
        Unkown = 0,
        [EnumMember(Value = "ACCPAYCREDIT")]
        AccountsPayable,
        [EnumMember(Value = "ACCRECCREDIT")]
        AccountsReceivable        
    }
}