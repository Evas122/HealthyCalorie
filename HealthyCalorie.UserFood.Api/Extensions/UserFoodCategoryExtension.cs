using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodCategoryExtension
    {
        public static UserFoodCategoryDto ToDto(this UserFoodCategory entity)
        {
            return new UserFoodCategoryDto
            {
                Id = entity.Id,
                Description = entity.Description,
            };
        }
    }
}
