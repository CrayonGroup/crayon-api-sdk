using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Domain
{
    public class AgreementCollection : ApiCollection<Agreement>
    {
        public AgreementFilter Filter { get; set; }
    }
}