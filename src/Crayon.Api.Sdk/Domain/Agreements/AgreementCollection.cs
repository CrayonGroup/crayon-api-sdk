using Crayon.Api.Sdk.Domain.Common;
using Crayon.Api.Sdk.Filtering;

namespace Crayon.Api.Sdk.Domain.Agreements
{
    public class AgreementCollection : ApiCollection<Agreement>
    {
        public AgreementFilter Filter { get; set; }
    }
}