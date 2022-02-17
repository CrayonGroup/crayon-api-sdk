using System;

namespace Crayon.Api.Sdk.Domain
{
    public class Grouping
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ObjectReference InvoiceProfile { get; set; }

        public ObjectReference Organization { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsDisabled { get; set; }

        public bool IsRemoved { get; set; }

        public string InvoiceReference { get; set; }
    }
}