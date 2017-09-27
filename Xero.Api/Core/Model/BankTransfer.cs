using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class BankTransfer : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "BankTransferID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public Account FromBankAccount { get; set; }

        [DataMember]
        public Account ToBankAccount { get; set; }

        [DataMember(Name = "FromBankTransactionID", EmitDefaultValue = false)]
        public Guid FromBankTransactionId { get; set; }

        [DataMember(Name = "ToBankTransactionID", EmitDefaultValue = false)]
        public Guid ToBankTransactionId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? CurrencyRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }
    }
}