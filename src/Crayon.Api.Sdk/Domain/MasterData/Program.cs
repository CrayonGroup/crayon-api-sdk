namespace Crayon.Api.Sdk.Domain.MasterData
{
    public class Program
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCommitment { get; set; }

        public ObjectReference Publisher { get; set; }
    }
}