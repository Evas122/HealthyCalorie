using HealthyCalorie.Common.Api.Service;
using HealthyCalorie.Common.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Api.Extensions;
using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.Recipe.Storage;

namespace HealthyCalorie.Recipe.Api.Services
{
    public class RecipeIngredientService : CrudServiceBase<RecipeDbContext, Storage.Entities.RecipeIngredient, RecipeIngredientDto>
    {
        private RecipeDbContext _recipeDbContext;

        public RecipeIngredientService(RecipeDbContext recipeDbContext) : base(recipeDbContext)
        {
            _recipeDbContext = recipeDbContext;
        }

        public async Task<RecipeIngredientDto> GetById(int id)
        {
            var recipeingredient = await base.GetById(id);
            return recipeingredient.ToDto();
        }

        public async Task<IEnumerable<RecipeIngredientDto>> Get()
        {
            var recipes = await base.Get();
            return recipes.Select(e => e.ToDto());
        }

        public async Task<CrudOperationResult<RecipeIngredientDto>> Create(RecipeIngredientDto dto)
        {
            var entity = dto.ToEntity();

            var entityId = await base.Create(entity);
            var newDto = await GetById(entityId);

            return new CrudOperationResult<RecipeIngredientDto>
            {
                Result = newDto,
                Status = CrudOperationResultStatus.Success
            };

        }

        public async Task<CrudOperationResult<RecipeIngredientDto>> Update(RecipeIngredientDto dto)
        {
            var entity = dto.ToEntity();
            return await base.Update(entity);
        }

        public async Task<CrudOperationResult<RecipeIngredientDto>> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
