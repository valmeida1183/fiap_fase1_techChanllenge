using Infraestructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Extensions;

public static class WebApiConfigurationExtension
{
    public static void ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
    }

    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }

    public static void ConfigureSwagger(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }
}
