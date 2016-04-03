using Crayon.Api.Sdk.Domain.Common;
using System;

namespace Crayon.Api.Sdk.Domain.Agreements
{
    public class Agreement
    {
        public int Id { get; set; }

        public ObjectReference Organization { get; set; }

        public string Name { get; set; }

        public string SalesPriceCurrencyCode { get; set; }

        public DateTimeOffset StartDate { get; set; }

        public DateTimeOffset EndDate { get; set; }

        public bool Disabled { get; set; }

        public ObjectReference Publisher { get; set; }

        public ObjectReference Program { get; set; }

        public string Number { get; set; }

        public string CustomerNumber { get; set; }

        public string MasterAgreement { get; set; }

        public bool HasTerms { get; set; }

        public bool IsActive(DateTimeOffset date)
        {
            return StartDate <= date && EndDate > date && !Disabled;
        }
    }
}