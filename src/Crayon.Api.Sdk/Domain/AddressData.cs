namespace Crayon.Api.Sdk.Domain
{
    public class AddressData
    {
        public long? AxAddressId { get; set; }

        public string Name { get; set; }

        public string CompleteAddress { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        public string CountryCode { get; set; }
    }
}