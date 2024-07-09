using HealthyCalorie.Common.Api.Service;
using HealthyCalorie.Common.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Api.Extensions;
using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Storage;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Identity.Client;

namespace HealthyCalorie.Recipe.Api.Services
{
    public class RecipeService : CrudServiceBase<RecipeDbContext, Storage.Entities.Recipe, RecipeDto>
    {
        private RecipeDbContext _recipeDbContext;

        public RecipeService(RecipeDbContext recipeDbContext) : base(recipeDbContext)
        {
            _recipeDbContext = recipeDbContext;
        }

        public async Task<RecipeDto> GetById(int id)
        {
            var recipe = await base.GetById(id);
            return recipe.ToDto();
        }

        public async Task<IEnumerable<RecipeDto>> Get()
        {
            var recipes = await base.Get();
            return recipes.Select(e => e.ToDto());
        }

        public async Task<CrudOperationResult<RecipeDto>> Create(RecipeDto dto)
        {
            var entity = dto.ToEntity();

            var entityId = await base.Create(entity);
            var newDto = await GetById(entityId);

            return new CrudOperationResult<RecipeDto>
            {
                Result = newDto,
                Status = CrudOperationResultStatus.Success
            };

        }

        public async Task<CrudOperationResult<RecipeDto>> Update(RecipeDto dto)
        {
            var entity = dto.ToEntity();
            return await base.Update(entity);
        }

        public async Task<CrudOperationResult<RecipeDto>> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
