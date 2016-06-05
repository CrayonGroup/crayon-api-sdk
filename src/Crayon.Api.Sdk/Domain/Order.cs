using System;

namespace Crayon.Api.Sdk.Domain
{
    public class Order
    {
        public string AxDataAreaId { get; set; }
        public string AxOrderId { get; set; }
        public string AxOrganizationId { get; set; }
        public string OrganizationVat { get; set; }
        public string OrganizationName { get; set; }
        public DateTimeOffset CreateDate { get; set; }
        public string ContactPersonAtCrayon { get; set; }

        /// <summary>
        /// CUSTOMERREF
        /// </summary>
        public string CustomerReference { get; set; }

        /// <summary>
        /// PURCHORDERFORMNUM
        /// </summary>
        public string CustomerRequsition { get; set; }

        public AddressData DeliveryAddress { get; set; }
        public string LanguageCode { get; set; }
        public string Source { get; set; }
        public int Status { get; set; }
        public int SalesType { get; set; }
        public int DocumentStatus { get; set; }
        public string PoolName { get; set; }
        public string OrderStatus { get; set; }
        public string AxOrderTransactionId { get; set; }
        public Price TotalPrice { get; set; }
    }
}