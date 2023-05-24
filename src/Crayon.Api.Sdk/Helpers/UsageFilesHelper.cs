using System;

namespace Crayon.Api.Sdk.Helpers
{
    public static class UsageFilesHelper
    {
        public static class AzureUsageFilesHelper
        {
            public static bool IsValidYearAndMonth(int year, int month)
            {
                try
                {
                    new DateTime(year, month, 1);
                    return true;
                }
                catch (ArgumentOutOfRangeException)
                {
                    return false;
                }
            }
        }
    }
}
