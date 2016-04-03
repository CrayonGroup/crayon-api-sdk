namespace Crayon.Api.Sdk.Filtering
{
    public interface IPaginationFilter : IFilter
    {
        int Page { get; }
        int PageSize { get; }
    }
}