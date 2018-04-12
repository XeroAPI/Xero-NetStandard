using System;
using System.Runtime.Serialization;

namespace Xero.Api.Core.Model
{
    [DataContract(Namespace = "")]
    public sealed class HistoryRecord 
    {
        [DataMember]
        public string Changes { get; set; }

        [DataMember(Name = "DateUTC")]
        public DateTime DateUtc { get; set; }

        [DataMember]
        public string User { get; set; }

        [DataMember]
        public string Details { get; set; }
    }
}