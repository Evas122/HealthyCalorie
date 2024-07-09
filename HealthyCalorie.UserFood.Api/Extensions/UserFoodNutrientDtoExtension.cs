using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodNutrientDtoExtension
    {
        public static UserFoodNutrient ToEntity(this UserFoodNutrientDto dto)
        {
            return new UserFoodNutrient
            {
                Id = dto.Id,
                NutrientId = dto.NutrientId,
                FoodId = dto.FoodId,
                Amount = dto.Amount,
            };
        }
    }
}
