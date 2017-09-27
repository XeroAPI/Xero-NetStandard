using System;
using System.Runtime.Serialization;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class EarningsLine
    {
        [DataMember(Name = "EarningsTypeID")]
        public Guid EarningsTypeId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? RatePerUnit { get; set; }        

        [DataMember]
        public decimal? UnitsOrHours { get; set; }
    } 
}