using Microsoft.AspNetCore.Mvc;
using HealthyCalorie.Food.Api.Services;

namespace HealthyCalorie.Food.Demo.Controllers
{
    public class FoodDemoController : Controller
    {
        private readonly FoodService _foodService; // Wstrzykiwanie FoodService

        public FoodDemoController(FoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<IActionResult> FoodIndex()
        {
            var foods = await _foodService.Get(); // Pobranie listy produktów spożywczych
            return View(foods); // Przekazanie danych do widoku
        }

        public async Task<IActionResult> Details(int id)
        {
            var food = await _foodService.GetById(id); // Pobranie szczegółowych danych o produkcie spożywczym
            if (food == null)
            {
                return NotFound();
            }
            return View(food); // Przekazanie danych do widoku
        }
    }

}
