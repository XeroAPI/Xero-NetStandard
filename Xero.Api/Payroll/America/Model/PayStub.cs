using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.Common.Model;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "", Name = "Paystub")]
    public class PayStub : PayNotice
    {
        [DataMember(Name = "PaystubID")]
        public Guid Id { get; set; }

        [DataMember]
        public decimal? Earnings { get; set; }        
    }
}
