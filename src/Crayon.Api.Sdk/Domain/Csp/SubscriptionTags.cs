using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionTags
    {
        public int SubscriptionId { get; set; }

        public string CostCenter { get; set; }

        public string Department { get; set; }

        public string Project { get; set; }

        public string Custom { get; set; }

        public string Owner { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
