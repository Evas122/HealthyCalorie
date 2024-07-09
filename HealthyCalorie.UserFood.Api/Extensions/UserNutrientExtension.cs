using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserNutrientExtension
    {
        public static UserNutrientDto ToDto(this UserNutrient entity)
        {
            return new UserNutrientDto
            {
                Id = entity.Id,
                Name = entity.Name,
                UnitName = entity.UnitName
            };
        }
    }
}
