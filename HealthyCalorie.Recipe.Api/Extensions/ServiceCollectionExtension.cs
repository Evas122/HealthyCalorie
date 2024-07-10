using HealthyCalorie.Recipe.Api.Services;
using HealthyCalorie.Recipe.Storage;

namespace HealthyCalorie.Recipe.Api.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddRecipeServices(this IServiceCollection services)
        {
            services.AddTransient<RecipeService>();
            services.AddDbContext<RecipeDbContext, RecipeDbContext>();
            return services;
        }
    }
}
