using feedbackapi.DAL;
using feedbackapi.Utils;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        ConfigurationManager configuration = builder.Configuration;
        var connectionString = configuration.GetConnectionString("DefaultConnectionString");

        var serverVersion = new MySqlServerVersion(new Version(8, 0, 3));
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseMySql(connectionString, serverVersion);
        });
        DIM.DependencyInjection(builder);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.EnvironmentName == "dev")
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.Services.GetRequiredService<Seed>().SeedData();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}