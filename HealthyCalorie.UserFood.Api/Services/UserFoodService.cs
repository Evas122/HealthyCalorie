using HealthyCalorie.Common.Api.Service;
using HealthyCalorie.Common.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Api.Extensions;
using HealthyCalorie.UserFood.CrossCutting.Dtos;
using HealthyCalorie.UserFood.Storage;

namespace HealthyCalorie.UserFood.Api.Services
{
    public class UserFoodService : CrudServiceBase<UserFoodDbContext, Storage.Entities.UserFood, UserFoodDto>
    {
        private UserFoodDbContext _userFoodDbContext;

        public UserFoodService(UserFoodDbContext userFoodDbContext) : base(userFoodDbContext)
        {
            _userFoodDbContext = userFoodDbContext;
        }

        public async Task<UserFoodDto> GetById(int id)
        {
            var userFood = await base.GetById(id);
            return userFood.ToDto();
        }

        public async Task<IEnumerable<UserFoodDto>> Get()
        {
            var userFoods = await base.Get();
            return userFoods.Select(e => e.ToDto());
        }

        public async Task<CrudOperationResult<UserFoodDto>> Create(UserFoodDto dto)
        {
            var entity = dto.ToEntity();

            var entityId = await base.Create(entity);
            var newDto = await GetById(entityId);

            return new CrudOperationResult<UserFoodDto>
            {
                Result = newDto,
                Status = CrudOperationResultStatus.Success
            };
        }

        public async Task<CrudOperationResult<UserFoodDto>> Update(UserFoodDto dto)
        {
            var entity = dto.ToEntity();
            return await base.Update(entity);
        }

        public async Task<CrudOperationResult<UserFoodDto>> Delete(int id)
        {
            return await base.Delete(id);
        }
    }
}
