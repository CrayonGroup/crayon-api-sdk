
namespace Crayon.Api.Sdk.Domain
{
    public class AgreementReport
    {
        public ObjectReference ProductContainer { get; set; }
        public AgreementIdentityReference Agreement { get; set; }
        public AgreementReportStatus Status { get; set; }
    }
}
