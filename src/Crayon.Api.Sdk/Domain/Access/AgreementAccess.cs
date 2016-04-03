using Crayon.Api.Sdk.Domain.Agreements;

namespace Crayon.Api.Sdk.Domain.Access
{
    public class AgreementAccess
    {
        public bool HasAccess { get; set; }

        public Agreement Agreement { get; set; }
    }
}