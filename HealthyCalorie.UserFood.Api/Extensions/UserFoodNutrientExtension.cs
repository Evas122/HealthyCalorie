using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodNutrientExtension
    {
        public static UserFoodNutrientDto ToDto(this UserFoodNutrient entity)
        {
            return new UserFoodNutrientDto
            {
                Id = entity.Id,
                NutrientId = entity.NutrientId,
                FoodId = entity.FoodId,
                Amount = entity.Amount,
            };
        }
    }
}
