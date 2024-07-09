using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class NutrientDtoExtension
    {
        public static Nutrient ToEntity(this NutrientDto dto)
        {
            return new Nutrient
            {
                Id = dto.Id,
                Name = dto.Name,
                UnitName = dto.UnitName,
            };
        }
    }
}
