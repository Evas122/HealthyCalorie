using HealthyCalorie.Recipe.CrossCutting.Dtos;

namespace HealthyCalorie.Recipe.Api.Extensions
{
    public static class RecipeExtension
    {
        public static RecipeDto ToDto(this Storage.Entities.Recipe entity)
        {
            return new RecipeDto
            {
                Id = entity.Id,
                UserId = entity.UserId,
                Description = entity.Description,
                Title = entity.Title,
                Url = entity.Url,
            };
        }
    }
}
