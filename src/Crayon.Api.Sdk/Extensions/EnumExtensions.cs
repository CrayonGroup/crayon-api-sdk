using System;
using System.Collections.Generic;
using Crayon.Api.Sdk.Domain;

namespace Crayon.Api.Sdk.Extensions
{
    public static class EnumExtensions
    {
        public static ApiCollection<ObjectReference> GetValues<T>()
        {
            var values = new List<ObjectReference>();
            foreach (var itemType in Enum.GetValues(typeof(T)))
            {
                //For each value of this enumeration, add a new EnumValue instance
                values.Add(new ObjectReference
                {
                    Name = Enum.GetName(typeof(T), itemType),
                    Id = (int)itemType
                });
            }
            return new ApiCollection<ObjectReference>(values, values.Count);
        }
    }
}
