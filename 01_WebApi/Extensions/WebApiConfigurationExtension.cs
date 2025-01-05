using Application.Service;
using Application.Service.Interface;
using Core.Repository.Interface;
using Infraestructure.Configuration;
using Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace WebApi.Extensions;

public static class WebApiConfigurationExtension
{
    public static void ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddMemoryCache();

        builder.Services
            .AddControllers()
            .ConfigureApiBehaviorOptions(options =>
            {
                // Configura para o ModelBindig não validar a model automaticamente, pois o default é validar mas eu quero um retorno personalizado na api
                options.SuppressModelStateInvalidFilter = true;
            })
            .AddJsonOptions(x =>
            {
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; // remove o problema das referencias em ciclos
            });
    }

    public static void ConfigureDbContext(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
    }

    public static void ConfigureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IContactService, ContactService>();
        builder.Services.AddScoped<IDirectDistanceDialingService, DirectDistanceDialingService>();

        builder.Services.AddScoped<IContactRepository, ContactRepository>();
        builder.Services.AddScoped<IDirectDistanceDialingRepository, DirectDistanceDialingRepository>();
    }    

    public static void ConfigureSwagger(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
    }
}
