using HealthyCalorie.Food.Api.Services;
using HealthyCalorie.Food.Storage;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddFoodServices(this IServiceCollection services)
        {
            services.AddTransient<FoodService>();
            services.AddDbContext<FoodDbContext, FoodDbContext>();
            return services;
        }
    }
}
