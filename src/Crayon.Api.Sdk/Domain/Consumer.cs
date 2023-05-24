namespace Crayon.Api.Sdk.Domain
{
    public class Consumer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LegalName { get; set; }

        public ObjectReference Organization { get; set; }
    }
}
