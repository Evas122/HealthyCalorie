using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodCategoryDtoExtension
    {
        public static UserFoodCategory ToEntity(this UserFoodCategoryDto dto)
        {
            return new UserFoodCategory
            {
                Id = dto.Id,
                Description = dto.Description,
            };
        }
    }
}
