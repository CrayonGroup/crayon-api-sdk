﻿namespace Crayon.Api.Sdk.Domain.Csp
{
    public class NextTermInstructionsResult
    {
        public bool IsSuccessful { get; set; }
        public string ErrorReasonCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}
