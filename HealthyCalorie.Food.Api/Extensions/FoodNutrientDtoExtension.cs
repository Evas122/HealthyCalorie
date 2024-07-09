using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodNutrientDtoExtension
    {
        public static FoodNutrient ToEntity(this FoodNutrientDto dto)
        {
            return new FoodNutrient
            {
                Id = dto.Id,
                FdcId = dto.FdcId,
                NutrientId = dto.NutrientId,
                Amount = dto.Amount,

            };
        }
    }
}
