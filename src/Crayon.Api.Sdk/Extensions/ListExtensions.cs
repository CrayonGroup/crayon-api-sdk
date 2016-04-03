using System;
using System.Collections.Generic;
using System.Linq;

namespace Crayon.Api.Sdk.Extensions
{
    public static class ListExtensions
    {
        public static List<int> GetIntListFromString(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(s => {
                    int num;
                    int.TryParse(s, out num);
                    return num;
                }).Where(i => i > 0).ToList();
            }

            return new List<int>();
        }

        public static List<string> GetStringListFromString(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return str.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            return new List<string>();
        }
    }
}