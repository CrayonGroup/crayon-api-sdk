namespace Crayon.Api.Sdk.Domain
{
    public class InvoiceProfile
    {
        public int Id { get; set; }

        public ObjectReference Organization { get; set; }

        public string Name { get; set; }

        public string InvoiceReference { get; set; }

        public string CustomerReference { get; set; }

        public string RequisitionNumber { get; set; }

        public long InvoiceAddressId { get; set; }

        public long? DeliveryAddressId { get; set; }

        public AddressData DeliveryAddress { get; set; }

        public AddressData InvoiceAddress { get; set; }

        public int? ConsumerId { get; set; }
        public int? ContactPersonId { get; set; }

    }
}