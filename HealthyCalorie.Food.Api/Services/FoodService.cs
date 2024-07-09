using HealthyCalorie.Food.Api.Extensions;
using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Food.Storage;
using Microsoft.EntityFrameworkCore;

namespace HealthyCalorie.Food.Api.Services
{
    public class FoodService
    {
        private readonly FoodDbContext _foodDbContext;

        public FoodService(FoodDbContext foodDbContext)
        {
            _foodDbContext = foodDbContext;
        }

        public async Task<IEnumerable<FoodDto>> Get()
        {
            var foods = await _foodDbContext.Foods
                .Include(f => f.FoodCategory)
                .ToListAsync();
            return foods.Select(x => x.ToBasicDto());
        }

        public async Task<FoodDto> GetById(int id)
        {
            var food = await _foodDbContext.Foods
               .Include(f => f.FoodCategory)
               .Include(f => f.FoodNutrients)
                   .ThenInclude(fn => fn.Nutrient)
               .FirstOrDefaultAsync(x => x.FdcId == id);
            return food == null ? new FoodDto() : food.ToDto();
        }


    }
}
