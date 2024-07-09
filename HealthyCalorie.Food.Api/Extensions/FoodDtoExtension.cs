using HealthyCalorie.Food.CrossCutting.Dtos;

namespace HealthyCalorie.Food.Api.Extensions
{
    public static class FoodDtoExtension
    {
        public static Storage.Entities.Food ToEntity(this FoodDto dto)
        {
            return new Storage.Entities.Food
            {
                FdcId = dto.FdcId,
                FoodCategoryId = dto.FoodCategoryId,
                DataType = dto.DataType,
                Description = dto.Description,
            };
        }
    }
}
