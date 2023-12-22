using DependencyInjection.Repositories;
using DependencyInjection.Repositories.Contracts;
using DependencyInjection.Services;
using DependencyInjection.Services.Contracts;
using Microsoft.Data.SqlClient;

namespace DependencyInjection;

public static class DependencyExtensions
{
    public static string AddConfigConnection(this IConfiguration configuration)
    {
        return configuration.GetValue<string>("ConnectionString");
    }
    public static void AddSqlConnection(this IServiceCollection services, string connectionString)
    {
        services.AddScoped<SqlConnection>(x => new SqlConnection(connectionString));
    }
    public static void AddResposories(this IServiceCollection services)
    {
        services.AddTransient<ICustomerRepository, CustomerRepository>();
        services.AddTransient<IPromoCodeRepository, PromoCodeRepository>();
    }
    public static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IDeliveryFeeService, DeliveryFeeService>();
    }

    
}