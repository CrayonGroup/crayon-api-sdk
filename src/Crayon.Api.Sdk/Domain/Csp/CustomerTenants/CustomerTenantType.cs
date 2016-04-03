namespace Crayon.Api.Sdk.Domain.CloudProvisioning.CustomerTenants
{
    public enum CustomerTenantType
    {
        /// <summary>
        /// Customer type is not specified
        /// </summary>
        None = 0,

        /// <summary>
        /// T1 customer type
        /// </summary>
        T1 = 1,

        /// <summary>
        /// T2 is the default customer type, end customer that belongs to a reseller
        /// </summary>
        T2 = 2
    }
}