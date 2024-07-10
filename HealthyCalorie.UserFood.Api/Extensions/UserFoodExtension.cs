using HealthyCalorie.UserFood.CrossCutting.Dtos;
using Microsoft.Identity.Client;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodExtension
    {
        public static UserFoodDto ToDto(this Storage.Entities.UserFood entity)
        {
            return new UserFoodDto
            {
                Id = entity.Id,
                FoodCategoryId = entity.FoodCategoryId,
                DataType = entity.DataType,
                Description = entity.Description,
                UserFoodNutrients = entity.UserFoodsNutrients.Select(fn => new UserFoodNutrientDto
                { Id = fn.Id,
                  NutrientId = fn.NutrientId,
                  NutrientName = fn.Nutrient.Name,
                  Amount = fn.Amount,
                  FoodId = fn.FoodId

                }).ToList()
            };
        }
        public static UserFoodDto ToBasicDto(this Storage.Entities.UserFood entity)
        {
            return new UserFoodDto
            {
                Id = entity.Id,
                FoodCategoryId = entity.FoodCategoryId,
                DataType = entity.DataType,
                Description = entity.Description,
                UserFoodNutrients = new List<UserFoodNutrientDto>()
            };
        }
    }
}
