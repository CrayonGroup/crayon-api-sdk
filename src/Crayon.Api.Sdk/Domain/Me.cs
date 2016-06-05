using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class Me
    {
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Token { get; set; }

        public List<string> Claims { get; set; }
    }
}