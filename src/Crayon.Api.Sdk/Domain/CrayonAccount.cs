using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crayon.Api.Sdk.Domain.Csp;

namespace Crayon.Api.Sdk.Domain
{
    public class CrayonAccount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public ObjectReference Publisher { get; set; }

        public string ExternalPublisherCustomerId { get; set; }

        public string Reference { get; set; }

        public CustomerTenantType CustomerTenantType { get; set; }

        public EntityStatus EntityStatus { get; set; }

        public Organization Organization { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public bool IsActivated { get; set; }

        public CustomerTenantContact Contact { get; set; }

        public ObjectReference Program { get; set; }
        public decimal ResellerMarkup { get; set; }
    }
}
