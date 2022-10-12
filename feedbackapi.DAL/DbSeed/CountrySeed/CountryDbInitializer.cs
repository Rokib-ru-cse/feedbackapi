using feedbackapi.DAL.Table;
using feedbackapi.Model.EntityModels;

namespace feedbackapi.DAL.DbSeed.CountrySeed
{
    public class CountryDbInitializer
    {
        private readonly AppDbContext dbContext;

        public CountryDbInitializer(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void SeedCountry()
        {
            if (TableCheck.CheckTableExists<Country>(dbContext))
            {
                if (!dbContext.Countries.Any())
                {
                    var countries = new List<Country>()
                {
                    new Country()
                    {
                        Id = 1,
                        Name = "Bangladesh",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new Country()
                    {
                        Id = 2,
                        Name = "India",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    },
                    new Country()
                    {
                        Id = 3,
                        Name = "Pakistan",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    }
                };
                    dbContext.Countries.AddRange(countries);
                    dbContext.SaveChanges();
                }
            }
        }
    }
}
