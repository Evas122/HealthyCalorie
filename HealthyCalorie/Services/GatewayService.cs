using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Gateway.Resolvers;
using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.UserFood.CrossCutting.Dtos;

namespace HealthyCalorie.Gateway.Services
{
    public class GatewayService
    {
        private readonly FoodResolver _foodResolver;
        private readonly UserFoodResolver _userFoodResolver;
        private readonly RecipeResolver _recipeResolver;

        public GatewayService(FoodResolver foodResolver, UserFoodResolver userFoodResolver, RecipeResolver recipeResolver)
        {
            _foodResolver = foodResolver;
            _userFoodResolver = userFoodResolver;
            _recipeResolver = recipeResolver;
        }

        public async Task<IEnumerable<FoodDto>> GetFoodsAsync()
        {
            return await _foodResolver.GetFoodsAsync();
        }

        public async Task<FoodDto?> GetFoodByIdAsync(int id)
        {
            return await _foodResolver.GetFoodByIdAsync(id);
        }

        public async Task<IEnumerable<RecipeDto>> GetRecipesAsync()
        {
            return await _recipeResolver.GetRecipesAsync();
        }

        public async Task<RecipeDto?> GetRecipeByIdAsync(int id)
        {
            return await _recipeResolver.GetRecipeByIdAsync(id);
        }

        public async Task<bool> CreateRecipeAsync(RecipeDto dto)
        {
            return await _recipeResolver.CreateRecipeAsync(dto);
        }

        public async Task<bool> DeleteRecipeAsync(int id)
        {
            return await _recipeResolver.DeleteRecipeAsync(id);
        }

        public async Task<IEnumerable<UserFoodDto>> GetUserFoodsAsync()
        {
            return await _userFoodResolver.GetUserFoodsAsync();
        }

        public async Task<UserFoodDto?> GetUserFoodByIdAsync(int id)
        {
            return await _userFoodResolver.GetUserFoodByIdAsync(id);
        }

        public async Task<bool> DeleteUserFoodAsync(int id)
        {
            return await _userFoodResolver.DeleteUserFoodAsync(id);
        }
    }
}
