using feedbackapi.BLL.Identity;
using feedbackapi.DAL;
using feedbackapi.Model.IdentityModels;
using feedbackapi.Utils;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

        builder.Services.AddDbContext<IdentityContext>(options =>
        {
            options.UseMySql(connectionString, serverVersion);
        });

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 4;
            options.Password.RequireNonAlphanumeric = false;
            options.User.RequireUniqueEmail = true;


        }).AddEntityFrameworkStores<IdentityContext>()
        .AddUserManager<CustomUserManager<ApplicationUser>>()
        .AddDefaultTokenProviders();




        //adding auth
        builder.Services.AddAuthentication(auth =>
        {
            auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            auth.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
            //adding jwtbearer
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "google.com",
                    ValidAudience = "google.com",
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("sadin")),
                    ValidateIssuerSigningKey = true

                };
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