using HealthyCalorie.Recipe.CrossCutting.Dtos;

namespace HealthyCalorie.Recipe.Api.Extensions
{
    public static class RecipeDtoExtension
    {
        public static Storage.Entities.Recipe ToEntity(this RecipeDto dto)
        {
            return new Storage.Entities.Recipe
            {
                Id = dto.Id,
                UserId = dto.UserId,
                Description = dto.Description,
                Title = dto.Title,
                Url = dto.Url,
            };
        }
    }
}
