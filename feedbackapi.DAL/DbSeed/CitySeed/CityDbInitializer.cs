using feedbackapi.DAL.Table;
using feedbackapi.Model.EntityModels;

namespace feedbackapi.DAL.DbSeed.CitySeed
{
    public class CityDbInitializer
    {
        private readonly AppDbContext _context;

        public CityDbInitializer(AppDbContext context)
        {
            _context = context;
        }

        public void SeedCity()
        {
            if (TableCheck.CheckTableExists<City>(_context))
            {
                if (!_context.Cities.Any())
                {
                    var Cities = new List<City>()
                    {
                        new City() {
                            Id = 1,
                            Name = "Dhaka",
                            CountryId = 1,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            },
                        new City() {
                            Id = 2,
                            Name = "Rajshahi",
                            CountryId = 1,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            },
                        new City() {
                            Id = 3,
                            Name = "New Delhi",
                            CountryId = 2,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            },
                        new City() {
                            Id = 4,
                            Name = "Mumbai",
                            CountryId = 2,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            },
                        new City() {
                            Id = 5,
                            Name = "Karachi",
                            CountryId = 3,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            },
                        new City() {
                            Id = 6,
                            Name = "Islamabad",
                            CountryId = 3,
                            CreatedAt = DateTime.Now,
                            UpdatedAt = DateTime.Now
                            }
                    };
                    _context.Cities.AddRange(Cities);
                    _context.SaveChanges();
                }
            }
        }

    }
}
