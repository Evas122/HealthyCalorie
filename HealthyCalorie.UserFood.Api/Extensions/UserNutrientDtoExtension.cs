using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage.Entities;

namespace HealthyCalorie.UserFood.Api.Extensions
{
    public static class UserNutrientDtoExtension
    {
        public static UserNutrient ToEntity(this UserNutrientDto dto)
        {
            return new UserNutrient
            {
                Id = dto.Id,
                Name = dto.Name,
                UnitName = dto.UnitName
            };
        }
    }
}
