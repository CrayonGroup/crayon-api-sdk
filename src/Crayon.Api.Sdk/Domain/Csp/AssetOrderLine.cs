using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class AssetOrderLine
    {
        public string ProductId { get; set; }

        public int? SubscriptionId { get; set; }

        public string ArmRegionName { get; set; }

        public string SkuId { get; set; }

        public int? ProductVariantId { get; set; }

        public int Quantity { get; set; }

        public BillingCycleType BillingCycle { get; set; }

        public Dictionary<string, string> ProvisioningContext { get; set; }

        public AssetType Type { get; set; }

        public bool RequiresInventoryCheck { get; set; }

        public string CatalogItemId { get; set; }

        public string TermDuration { get; set; }

        public AssetScope Scope { get; set; }

        public SalesPriceType ResellerPriceType { get; set; }

        public decimal ResellerPriceTypeValue { get; set; }

        public bool IsTrial { get; set; }

        public string Name { get; set; }

        public AssetTags Tags { get; set; }

        public ICollection<AssetOrderLineError> Errors { get; set; }
    }
}
