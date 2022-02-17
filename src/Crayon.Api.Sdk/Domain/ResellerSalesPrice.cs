using System;

namespace Crayon.Api.Sdk.Domain
{
    public class ResellerSalesPrice
    {
        public int ObjectId { get; set; }

        public ResellerSalesPriceObjectType ObjectType { get; set; }

        public ResellerSalesPriceType Type { get; set; }

        public ResellerSalesPricePriceType PriceType { get; set; }

        public decimal Value { get; set; }

        public DateTimeOffset FromDate { get; set; }

        public string ChangedBy { get; set; }
    }
}
