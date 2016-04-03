namespace Crayon.Api.Sdk.Domain.Products
{
    /// <summary>
    /// External Product
    /// </summary>
    public class ProductReference
    {
        /// <summary>
        /// External product id
        /// </summary>
        public int Id { get; set; }

        public string PartNumber { get; set; }

        public string ItemLegalName { get; set; }

        public string ItemName { get; set; }
    }
}