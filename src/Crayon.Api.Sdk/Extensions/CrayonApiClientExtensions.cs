using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering;
using Crayon.Api.Sdk.Resources;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Crayon.Api.Sdk.Extensions
{
    public static class CrayonApiClientExtensions
    {
        public static CrayonApiClientDataResult<ApiCollection<OrganizationAccess>> GetGrantForUser(this OrganizationAccessResource resource, string token, string userId)
        {
            return resource.GetGrant(token, 0, userId);
        }

        public static CrayonApiClientDataResult<ApiCollection<OrganizationAccess>> GetGrantForOrganization(this OrganizationAccessResource resource, string token, int organizationId)
        {
            return resource.GetGrant(token, organizationId, null);
        }

        public static CrayonApiClientDataResult<AgreementProductCollection> GetMicrosoftCspSeatProducts(this CrayonApiClient client, string token, AgreementProductFilter filter, bool includeAddOns)
        {
            filter.Include = filter.Include ?? new AgreementProductsSubFilter();
            filter.Include.PublisherNames = filter.Include.PublisherNames ?? new List<string>();
            filter.Include.ProgramNames = filter.Include.ProgramNames ?? new List<string>();
            filter.Include.ProductTypeNames = filter.Include.ProductTypeNames ?? new List<string>();

            Action<List<string>, string> includeValue = (list, s) => {
                string obj = list.FirstOrDefault(p => p.Equals(s, StringComparison.CurrentCultureIgnoreCase));
                if (obj == null)
                {
                    list.Add(s);
                }
            };

            //Add Microsoft filter
            includeValue(filter.Include.PublisherNames, "Microsoft");
            includeValue(filter.Include.ProgramNames, "CSP-T1");
            includeValue(filter.Include.ProgramNames, "CSP-T2");
            includeValue(filter.Include.ProgramNames, "CSP");
            includeValue(filter.Include.ProductTypeNames, "Subscription");
            if (includeAddOns)
            {
                includeValue(filter.Include.ProductTypeNames, "Subscription Add-On");
            }

            return client.AgreementProducts.Get(token, filter);
        }
    }
}