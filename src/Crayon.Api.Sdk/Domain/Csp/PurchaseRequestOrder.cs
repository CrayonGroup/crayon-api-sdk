using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class PurchaseRequestOrder
    {
        public string ExternalOrderId { get; set; }
        public string CountryCode { get; set; }
        public int ResellerCustomerId { get; set; }
        public string AdminAccount { get; set; }
        public string NotificationEmail { get; set; }
        public int? InvoiceProfileId { get; set; }
        public System.DateTime? ScheduledPurchaseDate { get; set; }

        public ICollection<PurchaseRequestOrderError> Errors { get; set; }
        public ICollection<PurchaseRequestOrderLine> OrderLines { get; set; }
    }
}
