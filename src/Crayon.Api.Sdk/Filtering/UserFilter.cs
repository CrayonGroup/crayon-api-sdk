using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Filtering
{
    public class UserFilter : IHttpFilter
    {
        public string Search { get; set; }
        public int OrganizationId { get; set; }
        public UserRole Role { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 50;

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}