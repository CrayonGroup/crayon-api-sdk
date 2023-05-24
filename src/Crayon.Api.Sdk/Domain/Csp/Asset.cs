using System;

namespace Crayon.Api.Sdk.Domain.Csp
{
    public class Asset
    {
        public int Id { get; set; }

        public AssetStatus Status { get; set; }

        public string ExternalOrderId { get; set; }

        public int Quantity { get; set; }

        public string ExternalProductId { get; set; }

        public string ExternalSkuId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public int ResellerCustomerId { get; set; }

        public AssetScope Scope { get; set; }

        public AssetType AssetType { get; set; }

        public BillingCycleType BillingCycle { get; set; }

        public int PublisherId { get; set; }

        public int ProgramId { get; set; }

        public string ReservationId { get; set; }

        public int? ReservationUsedInSubscriptionId { get; set; }

        public virtual SubscriptionLite ReservationUsedInSubscription { get; set; }

        public string PurchaseCurrency { get; set; }

        public decimal PurchasePrice { get; set; }

        public string SalesCurrency { get; set; }

        public decimal SalesPrice { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ChangedBy { get; set; }

        public string ReservedInstanceArtifactResourceId { get; set; }

        public DateTime? PurchaseDate { get; set; }

        public virtual ObjectReference InvoiceProfile { get; set; }

        public AssetTags Tags { get; set; }

        public bool? AutoRenewEnabled { get; set; }

        public int? ProductVariantId { get; set; }
    }
}
