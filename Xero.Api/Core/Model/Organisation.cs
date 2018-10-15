using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Model.Types;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public class Organisation
    {
        [DataMember(Name = "OrganisationID")]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LegalName { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ShortCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? PaysTax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public OrganisationVersion Version { get; set; }

        [DataMember(Name = "OrganisationEntityType", EmitDefaultValue = false)]
        public OrganisationType OrganisationType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsDemoCompany { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string BaseCurrency { get; set; }

        [DataMember(Name = "APIKey", EmitDefaultValue = false)]
        public string ApiKey { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public OrganisationStatus OrganisationStatus { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string TaxNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? FinancialYearEndDay { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int? FinancialYearEndMonth { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? PeriodLockDate { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public DateTime? EndOfYearLockDate { get; set; }

        [DataMember(Name = "CreatedDateUTC", EmitDefaultValue = false)]
        public DateTime? CreatedDateUtc { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Timezone { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string LineOfBusiness { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string RegistrationNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PaymentTerms PaymentTerms { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SalesTaxBasisType SalesTaxBasisType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public SalesTaxPeriodType SalesTaxPeriod { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Address> Addresses { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Phone> Phones { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<ExternalLink> ExternalLinks { get; set; }

        [DataMember]
        public OrganisationClass Class { get; set; }

        [DataMember]
        public OrganisationEdition Edition { get; set; }
    }
}
