using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Crayon.Api.Sdk.Filtering.Extensions
{
    public static class ObjectQueryExtensions
    {
        private static readonly ConcurrentDictionary<Type, List<PropertyInfo>> PropertyDictionary = new ConcurrentDictionary<Type, List<PropertyInfo>>();

        private static List<PropertyInfo> GetCachedProperties(Type type)
        {
            List<PropertyInfo> properties;
            if (PropertyDictionary.TryGetValue(type, out properties) == false)
            {
                properties = type.GetProperties().Where(x => x.CanRead).ToList();
                PropertyDictionary.TryAdd(type, properties);
            }

            return properties;
        }

        public static string ToUrlQuery(this object request)
        {
            if (request == null)
            {
                return string.Empty;
            }

            Dictionary<string, object> properties = GetCachedProperties(request.GetType())
                .Where(x => x.GetValue(request, null) != null)
                .ToDictionary(x => x.Name, x => x.GetValue(request, null));

            List<KeyValuePair<string, object>> result = ConvertPropertiesToList(properties);

            return string.Join("&", result.Select(x => string.Concat(Uri.EscapeDataString(x.Key), "=", Uri.EscapeDataString(x.Value.ToString()))));
        }

        private static List<KeyValuePair<string, object>> ConvertPropertiesToList(Dictionary<string, object> properties)
        {
            List<KeyValuePair<string, object>> result = new List<KeyValuePair<string, object>>();

            foreach (KeyValuePair<string, object> x in properties)
            {
                if (!(x.Value is string) && x.Value is IEnumerable)
                {
                    if (x.Value == null)
                    {
                        continue;
                    }

                    var valueType = x.Value.GetType();
                    var valueTypeInfo = valueType.GetTypeInfo();
                    var valueElemType = valueTypeInfo.IsGenericType ? valueType.GetGenericArguments()[0] : valueType.GetElementType();
                    var valueTypeInfo2 = valueElemType.GetTypeInfo();

                    if (valueTypeInfo2.IsPrimitive || valueElemType == typeof(string))
                    {
                        var enumerable = (IEnumerable)x.Value;
                        if (enumerable != null)
                        {
                            foreach (var child in enumerable)
                            {
                                result.Add(new KeyValuePair<string, object>(x.Key, ToValue(child)));
                            }
                            continue;
                        }
                    }
                }

                result.Add(new KeyValuePair<string, object>(x.Key, ToValue(x.Value)));
            }
            return result;
        }

        private static object ToValue(object obj)
        {
            if (obj == null)
            {
                return string.Empty;
            }

            var type = obj.GetType();
            var typeInfo = type.GetTypeInfo();

            if (typeInfo.IsEnum)
            {
                return (int)obj;
            }

            if (obj is DateTime)
            {
                //ISO 8601
                return ((DateTime)obj).ToString("O");
            }

            if (obj is DateTimeOffset)
            {
                //ISO 8601
                return ((DateTimeOffset)obj).ToString("O");
            }

            return obj;
        }
    }
}