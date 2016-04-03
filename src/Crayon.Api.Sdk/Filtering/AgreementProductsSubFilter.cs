using System.Collections.Generic;

namespace Crayon.Api.Sdk.Filtering
{
    public class AgreementProductsSubFilter
    {
        public List<int> PublisherIds { get; set; }
        public List<string> PublisherNames { get; set; }
        public List<string> PoolNames { get; set; }
        public List<string> OperatingSystemNames { get; set; }
        public List<string> LevelNames { get; set; }
        public List<string> LanguageNames { get; set; }
        public List<string> LicenseAgreementTypeNames { get; set; }
        public List<string> LicenseTypeNames { get; set; }
        public List<string> ProductFamilyNames { get; set; }
        public List<string> ProductTypeNames { get; set; }
        public List<string> ProgramNames { get; set; }
        public List<string> OfferingNames { get; set; }
        public List<string> PurchasePeriodNames { get; set; }
        public List<string> PurchaseUnitNames { get; set; }
        public List<string> VersionNames { get; set; }
        public List<string> RegionNames { get; set; }
        public List<string> ProductCategoryNames { get; set; }
    }
}