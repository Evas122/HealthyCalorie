using HealthyCalorie.User.CrossCutting.Dtos;
using HealthyCalorie.User.Storage.Entities;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class UserRoleExtension
    {
        public static UserRoleDto toDto(this UserRole entity)
        {
            return new UserRoleDto
            {
                Id = entity.Id,
                RoleId = entity.RoleId,
                UserId = entity.UserId,
            };
        }
    }
}
