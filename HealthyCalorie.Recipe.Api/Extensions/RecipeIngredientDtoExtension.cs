using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Storage.Entities;

namespace HealthyCalorie.Recipe.Api.Extensions
{
    public static class RecipeIngredientDtoExtension
    {
        public static RecipeIngredient ToEntity(this RecipeIngredientDto dto)
        {
            return new RecipeIngredient
            {
                Id = dto.Id,
                RecipeId = dto.RecipeId,
                FdcId = dto.FdcId,
                FoodId = dto.FoodId,
                Quantity = dto.Quantity,
                Unit = dto.Unit,
            };
        }
    }
}
