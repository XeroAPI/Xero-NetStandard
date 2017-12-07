using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model.Status;
using Xero.Api.Payroll.Australia.Model.Types;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class TaxDeclaration : HasUpdatedDate
    {
        [DataMember(Name = "EmployeeID", EmitDefaultValue = false)]
        public Guid EmployeeId { get; set; }

        [DataMember(Name = "TFNPendingOrExemptionHeld", EmitDefaultValue = false)]
        public bool TaxFileNumberPendingOrExemptionHeld { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public int TaxFileNumber { get; set; }

        [DataMember]
        public EmploymentBasisType EmploymentBasis { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool AustralianResidentForTaxPurposes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? TaxFreeThresholdClaimed { get; set; }

        [DataMember(Name = "HasHELPDebt", EmitDefaultValue = false)]
        public bool HasHigherEducationLoanProgramDebt { get; set; }

        [DataMember(Name = "HasSFSSDebt", EmitDefaultValue = false)]
        public bool HasStudentFinancialSupplementSchemeDebt { get; set; }

        [DataMember(Name = "HasTSLDebt", EmitDefaultValue = false)]
        public bool HasTradeSupportLoan { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool EligibleToReceiveLeaveLoading { get; set; }

        // Tax Offset Claimed        
        // Upward Variation Requested        
        // Has approved Leave Loading
        // Exempt from Flood and Cyclone Reconstruction Levy

        [DataMember(EmitDefaultValue = false)]
        public decimal? ApprovedWithholdingVariationPercentage { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? TaxOffsetEstimatedAmount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? UpwardVariationTaxWithholdingAmount { get; set; }


        [DataMember(Name = "TFNExemptionType", EmitDefaultValue = false)]
        public TaxFileNumberExemptionType? TaxFileNumberExemption { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ResidencyStatus? ResidencyStatus { get; set; }
    }
}
