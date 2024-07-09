using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage.Entities;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodNutrientExtension
    {
        public static FoodNutrientDto ToDto(this FoodNutrient entity)
        {
            return new FoodNutrientDto
            {
                Id = entity.Id,
                FdcId = entity.FdcId,
                NutrientId = entity.NutrientId,
                Amount = entity.Amount,

            };
        }
    }
}
