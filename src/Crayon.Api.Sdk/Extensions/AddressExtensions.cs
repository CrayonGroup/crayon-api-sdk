using Crayon.Api.Sdk.Domain.Addresses;
using System.Collections.Generic;
using System.Linq;

namespace Crayon.Api.Sdk.Extensions
{
    public static class AddressExtensions
    {
        public static string ToOneLineString(this Address address)
        {
            if (!string.IsNullOrWhiteSpace(address.CompleteAddress))
            {
                return address.CompleteAddress.Replace("\r\n", " ").Replace('\r', ' ').Replace('\n', ' ');
            }

            List<string> list = new[] { address.Name, address.Street, address.ZipCode, address.City, address.CountryCode }.Where(s => s.Length > 0).ToList();
            return string.Join(" ", list);
        }
    }
}