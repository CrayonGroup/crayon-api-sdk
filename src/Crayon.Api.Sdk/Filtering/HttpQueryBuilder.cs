using Crayon.Api.Sdk.Filtering.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Crayon.Api.Sdk.Filtering
{
    public static class HttpQueryBuilder
    {
        public const string QueryDelimiter = "?";
        public const string ParameterKeyValueDelimiter = "=";
        public const string ParameterDelimiter = "&";

        public static string Append(this string source, IHttpFilter filter)
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

        public static string ToQuery<T>(this T obj)
            where T : class
        {
            if (obj == null)
            {
                return string.Empty;
            }

            IDictionary<string, object> properties = obj.GetCachedProperties();
            var queryParams = properties
                .Select(pair => ToQueryParam(pair.Key, pair.Value))
                .Where(IsStringWithValue);

            return string.Join(ParameterDelimiter, queryParams);
        }

        private static string Append(this string source, string query)
        {
            return IsStringWithValue(query)
                ? $"{source}{QueryDelimiter}{query}"
                : source;
        }

        private static string ToQueryParam<T>(string key, T value)
        {
            if (!IsStringWithValue(key) || value == null)
            {
                return string.Empty;
            }

            if (!(value is string) && value is IEnumerable)
            {
                return ToQueryParam(key, value as IEnumerable);
            }

            var paramValue = ToQueryParam(value);

            if (!IsStringWithValue(paramValue))
            {
                return string.Empty;
            }

            key = Uri.EscapeDataString(key);
            paramValue = Uri.EscapeDataString(paramValue);

            return $"{key}{ParameterKeyValueDelimiter}{paramValue}";
        }

        private static string ToQueryParam<T>(T value)
        {
            var valueAsDateTime = value as DateTime?;
            if (valueAsDateTime.HasValue)
            {
                return valueAsDateTime.Value.ToString("O");
            }

            var valueAsDateTimeOffset = value as DateTimeOffset?;
            if (valueAsDateTimeOffset.HasValue)
            {
                return valueAsDateTimeOffset.Value.ToString("O");
            }

            if (value is Enum)
            {
                return Convert.ToInt32(value).ToString();
            }

            return value.ToString();
        }

        private static bool IsStringWithValue(string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        private static string ToQueryParam(string key, IEnumerable value)
        {
            var enumerable = value.Cast<object>();
            var paramValues = enumerable.Select(i => ToQueryParam(key, i)).Where(IsStringWithValue);
            return string.Join(ParameterDelimiter, paramValues);
        }
    }
}