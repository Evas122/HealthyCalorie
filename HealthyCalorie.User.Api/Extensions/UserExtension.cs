using HealthyCalorie.User.CrossCutting.Dtos;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class UserExtension
    {
        public static UserDto toDto(this Storage.Entities.User entity)
        {
            return new UserDto
            {
                Id = entity.Id,
                Email = entity.Email,
                UserName = entity.UserName,
                PasswordHash = entity.PasswordHash,
            };
        }
    }
}
