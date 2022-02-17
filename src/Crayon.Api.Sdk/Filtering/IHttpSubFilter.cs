namespace Crayon.Api.Sdk.Filtering
{
    public interface IHttpSubFilter
    {
        string ToQueryString(string parentName);
    }
}
