using HealthyCalorie.Recipe.Api.Services;
using HealthyCalorie.Recipe.CrossCutting.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HealthyCalorie.Recipe.Api.Controllers
{
    [Route("/recipe")]
    public class RecipeController : ControllerBase
    {
       private readonly RecipeService _recipeService;

        public RecipeController(RecipeService recipeService)
        {
            _recipeService = recipeService;
        }

        [HttpGet("recipes")]
        public async Task<IEnumerable<RecipeDto>> Read() => await _recipeService.Get();

        [HttpGet("recipes/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            var recipeDto = await _recipeService.GetById(id);

            if(recipeDto == null)
            {
                return NotFound();
            }
            return Ok(recipeDto);
        }

        [HttpPost("recipes")]
        public async Task<IActionResult> Create([FromBody] RecipeDto dto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var operationResult = await _recipeService.Create(dto);
            return Ok(operationResult);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            await _recipeService.Delete(id);
            return Ok();
        }
    }

}
