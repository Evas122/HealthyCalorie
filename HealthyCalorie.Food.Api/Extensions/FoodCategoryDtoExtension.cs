using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodCategoryDtoExtension
    {
        public static FoodCategory ToEntity(this FoodCategoryDto dto)
        {
            return new FoodCategory
            {
                Id = dto.Id,
                Description = dto.Description,
            };
        }
    }
}
