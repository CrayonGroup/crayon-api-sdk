using Crayon.Api.Sdk.Domain;
using Crayon.Api.Sdk.Filtering.Extensions;

namespace Crayon.Api.Sdk.Filtering
{
    public class UserFilter : IFilter
    {
        public string Search { get; set; }
        public int OrganizationId { get; set; }
        public UserRole Role { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;

        public string ToQueryString()
        {
            return this.ToUrlQuery();
        }
    }
}