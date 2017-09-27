using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Infrastructure.Interfaces;

namespace Xero.Api.Common
{
    public abstract class XeroResponse<T> : XeroResponse, IXeroResponse<T>
    {
        public abstract IList<T> Values { get; }        
    }

    [DataContract(Namespace = "")]
    public abstract class XeroResponse
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public string ProviderName { get; set; }

        [DataMember(Name = "DateTimeUTC", EmitDefaultValue = false)]
        public DateTime? DateTime { get; set; }
       

    }
}