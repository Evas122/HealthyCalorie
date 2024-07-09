using HealthyCalorie.User.CrossCutting.Dtos;

namespace HealthyCalorie.User.Api.Extensions
{
    public static class UserDtoExtension
    {
        public static Storage.Entities.User toEntity(this UserDto dto)
        {
            return new Storage.Entities.User
            {
                Id = dto.Id,
                Email = dto.Email,
                UserName = dto.UserName,
                PasswordHash = dto.PasswordHash,
            };
        }
    }
}
