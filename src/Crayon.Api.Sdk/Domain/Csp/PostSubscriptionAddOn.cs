using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class PostSubscriptionAddOn
    {
        public int Quantity { get; set; }
        public string OfferId { get; set; }
        public SubscriptionTags SubscriptionTags { get; set; }
    }
}
