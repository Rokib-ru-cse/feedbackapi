using feedbackapi.DAL.DbSeed.CategorySeed;
using feedbackapi.DAL.DbSeed.CitySeed;
using feedbackapi.DAL.DbSeed.CountrySeed;
using feedbackapi.DAL.DbSeed.SubCategorySeed;

namespace feedbackapi.Utils
{
    public class Seed
    {
        private readonly CountryDbInitializer countryDbInitializer;
        private readonly CityDbInitializer cityDbInitializer;
        private readonly CategoryDbInitializer categoryDbInitializer;
        private readonly SubCategoryDbInitializer subCategoryDbInitializer;
        public Seed(CountryDbInitializer countryDbInitializer,
            CityDbInitializer cityDbInitializer,
            CategoryDbInitializer categoryDbInitializer,
            SubCategoryDbInitializer subCategoryDbInitializer)
        {
            this.countryDbInitializer = countryDbInitializer;
            this.cityDbInitializer = cityDbInitializer;
            this.categoryDbInitializer = categoryDbInitializer;
            this.subCategoryDbInitializer = subCategoryDbInitializer;
        }
        public void SeedData()
        {
            countryDbInitializer.SeedCountry();
            cityDbInitializer.SeedCity();
            categoryDbInitializer.SeedCategory();
            subCategoryDbInitializer.SeedSubCategory();
        }
    }
}
