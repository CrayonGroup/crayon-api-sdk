namespace Crayon.Api.Sdk.Filtering
{
    public class GroupingFilter : IHttpFilter
    {
        public GroupingFilter()
        {
            Page = 1;
            PageSize = int.MaxValue - 1;
        }

        public int OrganizationId { get; set; }
        public bool IncludeRemoved { get; set; }
        public string Search { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}