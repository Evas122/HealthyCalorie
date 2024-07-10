using HealthyCalorie.Food.CrossCutting.Dtos;
using HealthyCalorie.Gateway.Services;
using HealthyCalorie.Recipe.CrossCutting.Dtos;
using HealthyCalorie.UserFood.CrossCutting.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HealthyCalorie.Gateway.Controllers
{
    [Route("gateway")]
    public class GatewayController : ControllerBase
    {
      private readonly GatewayService _gatewayService;

        public GatewayController(GatewayService gatewayService)
        {
            _gatewayService = gatewayService;
        }
        [HttpGet("foods")]
        public async Task<IEnumerable<FoodDto>> GetFoods()
        {
            return await _gatewayService.GetFoodsAsync();
        }

        [HttpGet("foods/{id}")]
        public async Task<IActionResult> GetFoodById(int id)
        {
            var foodDto = await _gatewayService.GetFoodByIdAsync(id);
            if (foodDto == null)
            {
                return NotFound();
            }
            return Ok(foodDto);
        }

        [HttpGet("recipes")]
        public async Task<IEnumerable<RecipeDto>> GetRecipes()
        {
            return await _gatewayService.GetRecipesAsync();
        }

        [HttpGet("recipes/{id}")]
        public async Task<IActionResult> GetRecipeById(int id)
        {
            var recipeDto = await _gatewayService.GetRecipeByIdAsync(id);
            if (recipeDto == null)
            {
                return NotFound();
            }
            return Ok(recipeDto);
        }

        [HttpPost("recipes")]
        public async Task<IActionResult> CreateRecipe([FromBody] RecipeDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _gatewayService.CreateRecipeAsync(dto);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("recipes/{id}")]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            var result = await _gatewayService.DeleteRecipeAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("userfoods")]
        public async Task<IEnumerable<UserFoodDto>> GetUserFoods()
        {
            return await _gatewayService.GetUserFoodsAsync();
        }

        [HttpGet("userfoods/{id}")]
        public async Task<IActionResult> GetUserFoodById(int id)
        {
            var userFoodDto = await _gatewayService.GetUserFoodByIdAsync(id);
            if (userFoodDto == null)
            {
                return NotFound();
            }
            return Ok(userFoodDto);
        }

        [HttpDelete("userfoods/{id}")]
        public async Task<IActionResult> DeleteUserFood(int id)
        {
            var result = await _gatewayService.DeleteUserFoodAsync(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }

}
