using feedbackapi.BLL.Repository;
using feedbackapi.BLL.Service;
using feedbackapi.DAL.DbSeed.CategorySeed;
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
            builder.Services.AddScoped<CategoryDbInitializer>();
            builder.Services.AddScoped<SubCategoryDbInitializer>();
            builder.Services.AddScoped<ICategoryBLRepository, CategoryBLService>();
            builder.Services.AddScoped<ISubCategoryBLRepository, SubCategoryBLService>();

        }
    }
}
