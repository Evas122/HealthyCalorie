using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class NutrientExtension
    {
        public static NutrientDto ToDto(this Nutrient entity)
        {
            return new NutrientDto
            {
                Id = entity.Id,
                Name = entity.Name,
                UnitName = entity.UnitName,
            };
        }
    }
}
