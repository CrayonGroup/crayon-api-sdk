using System.Collections.Generic;
using Crayon.Api.Sdk.Domain.Common;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Domain.Products
{
    public class AgreementProductCollection : ApiCollection<AgreementProduct>
    {
        public List<PublisherAggregationItem> Publishers { get; set; }
        public AgreementProductFilter Filter { get; set; }
        public List<AggregationItem> Pools { get; set; }
        public List<AggregationItem> OperatingSystems { get; set; }
        public List<AggregationItem> Offerings { get; set; }
        public List<AggregationItem> Levels { get; set; }
        public List<AggregationItem> Languages { get; set; }
        public List<AggregationItem> LicenseAgreementTypes { get; set; }
        public List<AggregationItem> LicenseTypes { get; set; }
        public List<AggregationItem> ProductFamilies { get; set; }
        public List<AggregationItem> Programs { get; set; }
        public List<AggregationItem> ProductTypes { get; set; }
        public List<AggregationItem> PurchasePeriods { get; set; }
        public List<AggregationItem> PurchaseUnits { get; set; }
        public List<AggregationItem> Versions { get; set; }
        public List<AggregationItem> Regions { get; set; }
        public List<AggregationItem> ProductCategories { get; set; }
        public List<ObjectReference> Agreements { get; set; }
    }
}