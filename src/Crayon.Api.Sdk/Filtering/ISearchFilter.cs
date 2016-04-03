namespace Crayon.Api.Sdk.Filtering
{
    public interface ISearchFilter : IFilter
    {
        string Search { get; }
    }
}