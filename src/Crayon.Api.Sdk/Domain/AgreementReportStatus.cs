
namespace Crayon.Api.Sdk.Domain
{
    public enum AgreementReportStatus
    {
        None = 0,
        NotReported = 1,
        ZeroUsageReported = 2, 
        UsageReported = 4,
        UsageAndZeroUsageReported = ZeroUsageReported | UsageReported
    }
}
