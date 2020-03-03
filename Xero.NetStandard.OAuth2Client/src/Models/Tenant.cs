using System;

namespace Xero.NetStandard.OAuth2.Models
{
    public class Tenant
    {
        public Guid Id { get; set; }
        public Guid TenantId { get; set; }
        public string TenantType { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
    }
}