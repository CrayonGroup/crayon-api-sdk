namespace Crayon.Api.Sdk.Domain.Csp
{
    public enum AssetSortBy
    {
        ProductName,
        /// <summary>
        /// Only applies to Software
        /// </summary>
        PurchaseDate,
        /// <summary>
        /// Only applies to Reserved Instance
        /// </summary>
        ExpirationDate
    }
}