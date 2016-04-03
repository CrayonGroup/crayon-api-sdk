using Crayon.Api.Sdk.Domain.Common;

namespace Crayon.Api.Sdk.Domain.MasterData.Programs
{
    public class Program
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ObjectReference Publisher { get; set; }
    }
}