using HealthyCalorie.Food.CrossCutting.Dtos;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodExtension
    {
        public static FoodDto ToDto(this Storage.Entities.Food entity)
        {
            return new FoodDto
            {
                FdcId = entity.FdcId,
                FoodCategoryId = entity.FoodCategoryId,
                DataType = entity.DataType,
                Description = entity.Description,
                FoodCategoryDescription = entity.FoodCategory?.Description,
                FoodNutrients = entity.FoodNutrients.Select(fn => new FoodNutrientDto
                {
                    Id = fn.Id,
                    NutrientId = fn.NutrientId,
                    NutrientName = fn.Nutrient.Name,
                    Amount = fn.Amount
                }).ToList()
            };
        }
        public static FoodDto ToBasicDto(this Storage.Entities.Food entity)
        {
            return new FoodDto
            {
                FdcId = entity.FdcId,
                FoodCategoryId = entity.FoodCategoryId,
                DataType = entity.DataType,
                Description = entity.Description,
                FoodCategoryDescription = entity.FoodCategory?.Description,
                FoodNutrients = new List<FoodNutrientDto>()
            };
        }
    }
}
