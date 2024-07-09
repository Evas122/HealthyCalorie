using HealthyCalorie.User.CrossCutting.Dtos;
using HealthyCalorie.User.Storage.Entities;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class UserRoleDtoExtension
    {
        public static UserRole toEntity(this UserRoleDto dto)
        {
            return new UserRole
            {
                Id = dto.Id,
                RoleId = dto.RoleId,
                UserId = dto.UserId,
            };
        }
    }
}
