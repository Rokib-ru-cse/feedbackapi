using feedbackapi.DAL.DbSeed.CategorySeed;
using feedbackapi.DAL.DbSeed.CitySeed;
using feedbackapi.DAL.DbSeed.CountrySeed;
using feedbackapi.DAL.DbSeed.SubCategorySeed;

namespace feedbackapi.Utils
{
    public class DIM
    {
        public static void DependencyInjection(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<Seed>();
            builder.Services.AddScoped<CountryDbInitializer>();
            builder.Services.AddScoped<CityDbInitializer>();
            builder.Services.AddScoped<CategoryDbInitializer>();
            builder.Services.AddScoped<SubCategoryDbInitializer>();

        }
    }
}
