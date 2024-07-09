using HealthyCalorie.Food.Api.Services;
using HealthyCalorie.Food.CrossCutting.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HealthyCalorie.Food.Api.Controllers
{
    [Route("/food")]
    public class FoodController : ControllerBase
    {
        private readonly FoodService _foodService;

        public FoodController(FoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet("foods")]
        public async Task<IEnumerable<FoodDto>> Read() => await _foodService.Get();

        [HttpGet("foods/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            var foodDto = await _foodService.GetById(id);

            if (foodDto == null)
            {
                return NotFound();
            }

            return Ok(foodDto);
        }
    }
}
