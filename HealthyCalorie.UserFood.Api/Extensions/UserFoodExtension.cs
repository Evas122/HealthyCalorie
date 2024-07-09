using HealthyCalorie.UserFood.CrossCutting.Dtos;


namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserFoodExtension
    {
        public static UserFoodDto ToDto(this Storage.Entities.UserFood entity)
        {
            return new UserFoodDto
            {
                Id = entity.Id,
                FoodCategoryId = entity.FoodCategoryId,
                DataType = entity.DataType,
                Description = entity.Description,
            };
        }
    }
}
