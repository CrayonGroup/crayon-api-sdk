using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Crayon.Api.Sdk.Filtering.Extensions
{
    internal static class ObjectExtensions
    {
        private static readonly ConcurrentDictionary<Type, IReadOnlyList<PropertyInfo>> PropertyDictionary = new ConcurrentDictionary<Type, IReadOnlyList<PropertyInfo>>();

        internal static IDictionary<string, object> GetCachedProperties<T>(this T obj)
            where T : class
        {
            var type = typeof(T);
            IReadOnlyList<PropertyInfo> properties;

            if (!PropertyDictionary.TryGetValue(type, out properties))
            {
                properties = type.GetTypeInfo().GetProperties()
                    .Where(property => property.CanRead)
                    .ToList();

                PropertyDictionary.TryAdd(type, properties);
            }

            return properties.ToDictionary(property => property.Name, property => property.GetValue(obj));
        }
    }
}