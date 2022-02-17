namespace Crayon.Api.Sdk.Domain
{
    public class Consumer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ObjectReference Organization { get; set; }
    }
}
