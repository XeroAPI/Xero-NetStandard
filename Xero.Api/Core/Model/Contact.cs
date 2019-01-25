using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Core.Model.Status;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Contact : HasUpdatedDate, IHasId, IHasAttachment
    {
        [DataMember(Name = "ContactID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ContactStatus ContactStatus { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ContactNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string FirstName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LastName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string SkypeUserName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string BankAccountDetails { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountsReceivableTaxType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountsPayableTaxType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsSupplier { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsCustomer { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string DefaultCurrency { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Website { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? Discount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string XeroNetworkKey { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "PurchasesDefaultAccountCode")]
        public string PurchaseAccountCode { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "SalesDefaultAccountCode")]
        public string SalesAccountCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<SalesTrackingCategory> SalesTrackingCategories { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<PurchasesTrackingCategory> PurchasesTrackingCategories { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public BrandingTheme BrandingTheme { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public BatchPaymentContactDefaults BatchPayments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Balances Balances { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PaymentTerms PaymentTerms { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ContactPerson> ContactPersons { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Phone> Phones { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ContactGroup> ContactGroups { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string AccountNumber { get; set; } 
    }
}