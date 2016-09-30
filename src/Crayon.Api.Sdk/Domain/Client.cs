using System;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    public class Client
    {
        public Client()
        {
            ClientSecrets = new List<Secret>();
            RedirectUris = new List<Uri>();
        }

        public string ClientId { get; set; }

        public string ClientName { get; set; }

        public Uri ClientUri { get; set; }

        public bool Enabled { get; set; }

        public List<Secret> ClientSecrets { get; set; }

        public List<Uri> RedirectUris { get; set; }

        public DateTimeOffset TimeStamp { get; set; }

        public Flow Flow { get; set; }
    }
}