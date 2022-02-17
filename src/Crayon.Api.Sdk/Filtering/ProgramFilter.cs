using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Filtering
{
    public class ProgramFilter : IHttpFilter
    {
        public ProgramFilter()
        {
            Search = string.Empty;
            Page = 1;
            PageSize = 1000;
        }

        public int PublisherId { get; set; }
        public ProgramType ProgramType { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string Search { get; set; }
        public int OrganizationId { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}