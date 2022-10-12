using feedbackapi.DAL.DbSeed.CitySeed;
using feedbackapi.DAL.DbSeed.CountrySeed;

namespace feedbackapi.Utils
{
    public class Seed
    {
        private readonly CountryDbInitializer countryDbInitializer;
        private readonly CityDbInitializer cityDbInitializer;
        public Seed(CountryDbInitializer countryDbInitializer,
            CityDbInitializer cityDbInitializer)
        {
            this.countryDbInitializer = countryDbInitializer;
            this.cityDbInitializer = cityDbInitializer;
        }
        public void SeedData()
        {
            countryDbInitializer.SeedCountry();
            cityDbInitializer.SeedCity();
        }
    }
}
