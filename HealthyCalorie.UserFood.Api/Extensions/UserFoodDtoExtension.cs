using HealthyCalorie.UserFood.CrossCutting.Dtos;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodDtoExtension
    {
        public static Storage.Entities.UserFood ToEntity(this UserFoodDto dto)
        {
            return new Storage.Entities.UserFood
            {
                Id = dto.Id,
                FoodCategoryId = dto.FoodCategoryId,
                DataType = dto.DataType,
                Description = dto.Description,
            };
        }
    }
}
