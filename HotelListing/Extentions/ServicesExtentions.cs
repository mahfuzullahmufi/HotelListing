using HotelListing.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using HotelListing.Configuration;

namespace CompanyEmployees.Extentions
{
    public static class ServiceExtensions
    {

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
             services.Configure<IISOptions>(options =>
             {

             });

        public static void ConfigureIdentity(this IServiceCollection services)
        {
            var builder = services.AddIdentityCore<ApiUser>(q => q.User.RequireUniqueEmail = true);
            builder = new IdentityBuilder(builder.UserType, typeof(IdentityRole), services);
            builder.AddEntityFrameworkStores<DatabaseContext>().AddDefaultTokenProviders();
        }

        //public static void ConfigureJWT(this IServiceCollection services)
        //{
            
        //    var jwtSettings = config.GetSection("Jwt").Value; 
        //    var key = config["Jwt:Key"];

        //    services.AddAuthentication(o =>
        //    {
        //        o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    })
        //    .AddJwtBearer(o =>
        //    {
        //        o.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            ValidateIssuer = true,
        //            ValidateAudience = false,
        //            ValidateLifetime = true,
        //            ValidateIssuerSigningKey = true,
        //            ValidIssuer = config["Jwt:Issuer"],
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
        //        };
        //    });
        //}

        //public static void ConfigureJWT(this IServiceCollection services, IConfiguration Configuration, WebApplicationBuilder builder)
        //{
        //    var jwtSettings = Configuration.GetSection("Jwt");
        //    //var key = Environment.GetEnvironmentVariable("KEY");

        //    services.AddAuthentication(o =>
        //    {
        //        o.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //        o.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //    })
        //    .AddJwtBearer(o =>
        //    {
        //        o.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            ValidateIssuer = true,
        //            ValidateAudience = false,
        //            ValidateLifetime = true,
        //            ValidateIssuerSigningKey = true,
        //            ValidIssuer = jwtSettings.GetSection("Issuer").Value,
        //            IssuerSigningKey = new SymmetricSecurityKey
        //                (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        //        };
        //    });
        //}



    }

}
