using HealthyCalorie.Gateway.Resolvers;
using HealthyCalorie.Gateway.Services;

namespace HealthyCalorie.Gateway.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddGatewayServices(this IServiceCollection services)
        {
            services.AddTransient<GatewayService>();
            services.AddHttpClient<FoodResolver>();
            services.AddHttpClient<UserFoodResolver>();
            services.AddHttpClient<RecipeResolver>();
            return services;
        }
    }
}
