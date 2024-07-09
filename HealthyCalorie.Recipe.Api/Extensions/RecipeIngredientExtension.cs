using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Storage.Entities;

namespace HealthyCalorie.Recipe.Api.Extensions
{
    public static class RecipeIngredientExtension
    {
        public static RecipeIngredientDto ToDto(this RecipeIngredient entity)
        {
            return new RecipeIngredientDto
            {
                Id = entity.Id,
                RecipeId = entity.RecipeId,
                FdcId = entity.FdcId,
                FoodId = entity.FoodId,
                Quantity = entity.Quantity,
                Unit = entity.Unit,
            };
        }
    }
}
