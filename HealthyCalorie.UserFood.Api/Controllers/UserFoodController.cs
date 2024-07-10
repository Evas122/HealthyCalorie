using HealthyCalorie.UserFood.Api.Services;
using HealthyCalorie.UserFood.CrossCutting.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace HealthyCalorie.UserFood.Api.Controllers
{
    [Route("/userfood")]
    public class UserFoodController : ControllerBase
    {
        private readonly UserFoodService _userFoodService;

        public UserFoodController(UserFoodService userFoodService)
        {
            _userFoodService = userFoodService;
        }

        [HttpGet("userfoods")]
        public async Task<IEnumerable<UserFoodDto>> Read() => await _userFoodService.Get();

        [HttpGet("userfoods/{id}")]
        public async Task<IActionResult> ReadById(int id)
        {
            var userFoodDto = await _userFoodService.GetById(id);

            if(userFoodDto == null)
            {
                return NotFound();
            }
            return Ok(userFoodDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id ==null)
            {
                return BadRequest();
            }

            await _userFoodService.Delete(id);
            return Ok();
        }
    }
}
