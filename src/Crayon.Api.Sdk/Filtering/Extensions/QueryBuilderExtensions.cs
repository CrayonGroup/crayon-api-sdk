using System;
using System.Collections.Generic;
using System.Reflection;

namespace Crayon.Api.Sdk.Filtering.Extensions
{
    public static class QueryBuilderExtensions
    {
        public const string QueryDelimiter = "?";
        public const string ParameterDelimter = "&";

        public static string Append(this string source, IFilter filter)
        {
            if (filter == null)
            {
                return source;
            }

            var query = filter.ToQueryString();

            return source.Append(query);
        }

        public static string Append<T>(this string source, string key, T value)
        {
            var queryParam = ToQueryParam(key, value);

            return source.Append(queryParam);
        }

        private static string Append(this string source, string query)
        {
            return IsStringWithValue(query)
                ? $"{source}{QueryDelimiter}{query}"
                : source;
        }

        private static string ToQueryParams(this DateTimeOffset? source, string key)
        {
            if (source == null)
            {
                return string.Empty;
            }

            return ToQueryParam(Uri.EscapeDataString(source.Value.ToString("o")), key);
        }

        private static bool IsStringWithValue(string str)
        {
            return !(string.IsNullOrEmpty(str) && string.IsNullOrWhiteSpace(str));
        }

        internal static string ToQueryParam<T>(string key, T value)
        {
            if (value == null)
            {
                return string.Empty;
            }

            var valueAsEnumerable = value as IEnumerable<object>;
            if (valueAsEnumerable != null)
            {
                return ToQueryParam(key, valueAsEnumerable);
            }

            var valueAsDateTime = value as DateTime?;
            if (valueAsDateTime != null)
            {
                return ToQueryParam(key, valueAsDateTime);
            }

            var sourceAsDateTimeOffset = value as DateTimeOffset?;
            if (sourceAsDateTimeOffset != null)
            {
                return ToQueryParams(sourceAsDateTimeOffset, key);
            }

            var valueAsString = value.ToString();

            if (typeof(T).GetTypeInfo().IsEnum)
            {
                return ToQueryParam(key, Convert.ToInt32(value).ToString());
            }

            return IsStringWithValue(valueAsString)
                ? $"{key}={value}"
                : string.Empty;
        }
    }
}