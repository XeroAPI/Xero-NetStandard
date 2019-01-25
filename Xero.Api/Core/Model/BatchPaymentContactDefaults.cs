using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "", Name = "BatchPayments")]
    public class BatchPaymentContactDefaults : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string BankAccountName { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string Details { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }        
    }
}