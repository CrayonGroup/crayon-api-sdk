using System.Collections.Generic;

namespace Crayon.Api.Sdk.Domain.Common
{
    public class ApiCollection<T>
    {
        public ApiCollection()
        {
            Items = new List<T>();
        }

        public ApiCollection(List<T> list, int totalHits)
        {
            Items = list ?? new List<T>();
            TotalHits = totalHits;
        }

        public List<T> Items { get; set; }

        public long TotalHits { get; set; }
    }
}