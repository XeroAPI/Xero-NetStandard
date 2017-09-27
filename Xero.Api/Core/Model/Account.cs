using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Account : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "AccountID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Code { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AccountStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AccountType Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public BankAccountType? BankAccountType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public AccountClassType Class { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SystemAccountType? SystemAccount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? EnablePaymentsToAccount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? ShowInExpenseClaims { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string BankAccountNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ReportingCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ReportingCodeName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }
    }
}