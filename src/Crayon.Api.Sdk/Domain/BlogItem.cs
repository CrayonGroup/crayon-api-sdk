﻿using System;

namespace Crayon.Api.Sdk.Domain
{
    public sealed class BlogItem
    {
        public string Title { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public Uri Link { get; set; }

        public DateTimeOffset PublicationDate { get; set; }
    }
}