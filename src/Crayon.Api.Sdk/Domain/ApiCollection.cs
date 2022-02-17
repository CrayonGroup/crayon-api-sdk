using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain
{
    [JsonObject]
    public class ApiCollection<T> : IEnumerable<T>
    {
        public ApiCollection()
        {
            Items = new List<T>();
        }

        public ApiCollection(List<T> list, long totalHits)
        {
            Items = list ?? new List<T>();
            TotalHits = totalHits;
        }

        public List<T> Items { get; set; }

        public long TotalHits { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}