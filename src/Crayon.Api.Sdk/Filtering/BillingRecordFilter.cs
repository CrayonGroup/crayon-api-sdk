namespace Crayon.Api.Sdk.Filtering
{
    public class BillingRecordFilter : IHttpFilter
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 1000;

        public string ToQueryString()
        {
            return this.ToQuery();
        }
    }
}