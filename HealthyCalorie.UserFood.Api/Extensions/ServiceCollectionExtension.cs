using HealthyCalorie.UserFood.Api.Services;
using HealthyCalorie.UserFood.Storage;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddUserFoodServices(this IServiceCollection services)
        {
            services.AddTransient<UserFoodService>();
            services.AddDbContext<UserFoodDbContext, UserFoodDbContext>();
            return services;
        }
    }
}
