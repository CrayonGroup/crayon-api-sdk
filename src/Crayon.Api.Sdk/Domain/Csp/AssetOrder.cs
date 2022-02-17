using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AssetOrder
    {
        public string ExternalOrderId { get; set; }
        public string CountryCode { get; set; }
        public int ResellerCustomerId { get; set; }
        public string AdminAccount { get; set; }
        public string NotificationEmail { get; set; }
        public int? InvoiceProfileId { get; set; }

        public ICollection<AssetOrderError> Errors { get; set; }
        public ICollection<AssetOrderLine> OrderLines { get; set; }
    }
}
