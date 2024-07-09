using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodCategoryExtension
    {
        public static FoodCategoryDto ToDto(this FoodCategory entity)
        {
            return new FoodCategoryDto
            {
                Id = entity.Id,
                Description = entity.Description,
            };
        }
    }
}
