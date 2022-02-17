using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class SubscriptionAddOnOffer
    {
        public ProductReference Product { get; set; }
        public ObjectReference Publisher { get; set; }
    }
}
