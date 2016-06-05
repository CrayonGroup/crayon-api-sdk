namespace Crayon.Api.Sdk.Domain
{
    public class Address
    {
        public long Id { get; set; }

        public ObjectReference Organization { get; set; }

        /// <summary>
        /// Name of the current address, company/building/person
        /// </summary>
        public string Name { get; set; }

        public string CompleteAddress { get; set; }

        public string Street { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        /// <summary>
        /// Note! This is the County, Not CountryName or CountryCode
        /// </summary>
        public string County { get; set; }

        public string State { get; set; }

        public string CountryCode { get; set; }

        public bool Primary { get; set; }

        public AddressType AddressType { get; set; }
    }
}