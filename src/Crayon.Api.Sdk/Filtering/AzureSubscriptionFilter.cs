namespace Crayon.Api.Sdk.Filtering
{
    public class AzureSubscriptionFilter : IHttpFilter
    {
        public string Search { get; set; }

        public int Page { get; set; }
        public int PageSize { get; set; }
        
        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}