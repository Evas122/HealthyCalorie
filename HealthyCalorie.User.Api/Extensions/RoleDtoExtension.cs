using HealthyCalorie.User.CrossCutting.Dtos;
using HealthyCalorie.User.Storage.Entities;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class RoleDtoExtension
    {
        public static Role toEntity(this RoleDto dto)
        {
            return new Role
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description,
            };
        }
    }
}
