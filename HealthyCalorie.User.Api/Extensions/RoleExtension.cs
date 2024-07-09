using HealthyCalorie.User.CrossCutting.Dtos;
using HealthyCalorie.User.Storage.Entities;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class RoleExtension
    {
        public static RoleDto toDto(this Role entity)
        {
            return new RoleDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
            };
        }
    }
}
