using System;
using System.Globalization;
using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Domain.Csp;
using Crayon.Api.Sdk.Requests;

namespace Crayon.Api.Sdk.Resources
{
    public class UsageCostResource
    {
        private readonly CrayonApiClient _client;

        public UsageCostResource(CrayonApiClient client)
        {
            _client = client;
        }

        public CrayonApiClientResult<ApiCollection<OrganizationUsageCost>> GetForOrganization(string token, int organizationId, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/organization/{organizationId}/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<OrganizationUsageCost>>(token, uri);
        }

        [Obsolete]
        public CrayonApiClientResult<ApiCollection<SubscriptionUsageCost>> GetForSubscription(string token, 
            int resellerCustomerId, string subscriptionId, string currencyCode, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/resellerCustomer/{resellerCustomerId}/subscription/{subscriptionId}/currency/{currencyCode}/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<SubscriptionUsageCost>>(token, uri);
        }

        [Obsolete]
        public CrayonApiClientResult<ApiCollection<CategoryUsageCost>> GetForCategory(string token, int resellerCustomerId, 
            string subscriptionId, string category, string currencyCode, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/resellerCustomer/{resellerCustomerId}/subscription/{subscriptionId}/category/{category}/currency/{currencyCode}/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<CategoryUsageCost>>(token, uri);
        }

        [Obsolete]
        public CrayonApiClientResult<ApiCollection<SubcategoryUsageCost>> GetForSubcategory(string token, int resellerCustomerId, 
            string subscriptionId, string category, string subcategory, string currencyCode, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/resellerCustomer/{resellerCustomerId}/subscription/{subscriptionId}/category/{category}/subcategory/{subcategory}/currency/{currencyCode}/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<SubcategoryUsageCost>>(token, uri);
        }
        
        [Obsolete]
        public CrayonApiClientResult<ApiCollection<SubscriptionResourceGroupUsageCost>> GetForSubscriptionWithResourceGroups(string token, 
            int resellerCustomerId, string subscriptionId, string currencyCode, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/resellerCustomer/{resellerCustomerId}/subscription/{subscriptionId}/currency/{currencyCode}/resourceGroups/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<SubscriptionResourceGroupUsageCost>>(token, uri);
        }
        
        [Obsolete]
        public CrayonApiClientResult<ApiCollection<ResourceGroupUsageCost>> GetForResourceGroup(
            string token, int resellerCustomerId, string subscriptionId, string resourceGroup, 
            string currencyCode, DateTime usagePeriodStart, DateTime usagePeriodEnd)
        {
            var usagePeriodStartFormated = usagePeriodStart.ToString("s", CultureInfo.InvariantCulture);
            var usagePeriodEndFormated = usagePeriodEnd.ToString("s", CultureInfo.InvariantCulture);
            var uri = $"/api/v1/usagecost/resellerCustomer/{resellerCustomerId}/subscription/{subscriptionId}/resourceGroup/{resourceGroup}/currency/{currencyCode}/?from={usagePeriodStartFormated}&to={usagePeriodEndFormated}";

            return _client.Get<ApiCollection<ResourceGroupUsageCost>>(token, uri);
        }
        
        // The new POST endpoints
                
        public CrayonApiClientResult<ApiCollection<SubscriptionUsageCost>> GetForSubscription(string token, SubscriptionUsageCostRequest request)
        {
            var uri = $"/api/v1/usagecost/getForSubscription";
            return _client.Post<ApiCollection<SubscriptionUsageCost>>(token, uri, request);
        }

        public CrayonApiClientResult<ApiCollection<CategoryUsageCost>> GetForCategory(string token, CategoryUsageCostRequest request)
        {
            var uri = $"/api/v1/usagecost/getForCategory";
            return _client.Post<ApiCollection<CategoryUsageCost>>(token, uri, request);
        }

        public CrayonApiClientResult<ApiCollection<SubcategoryUsageCost>> GetForSubcategory(string token, SubcategoryUsageCostRequest request)
        {
            var uri = $"/api/v1/usagecost/getForSubcategory";
            return _client.Post<ApiCollection<SubcategoryUsageCost>>(token, uri, request);
        }
        
        public CrayonApiClientResult<ApiCollection<SubscriptionResourceGroupUsageCost>> GetForSubscriptionWithResourceGroups(string token, SubscriptionUsageCostRequest request)
        {
            var uri = $"/api/v1/usagecost/getForSubscription/resourceGroups";
            return _client.Post<ApiCollection<SubscriptionResourceGroupUsageCost>>(token, uri, request);
        }
        
        public CrayonApiClientResult<ApiCollection<ResourceGroupUsageCost>> GetForResourceGroup(string token, 
            ResourceGroupUsageCostRequest request)
        {
            var uri = $"/api/v1/usagecost/getForResourceGroup";
            return _client.Post<ApiCollection<ResourceGroupUsageCost>>(token, uri, request);
        }
    }
}
