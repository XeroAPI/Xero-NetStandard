using System;

namespace Xero.NetStandard.OAuth2.Models
{
    public class Tenant
    {
        public Guid id { get; set; }
        public Guid TenantId { get; set; }
        public string TenantType { get; set; }
    }
}