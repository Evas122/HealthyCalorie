using HealthyCalorie.Food.CrossCutting.Dtos;

namespace HealthyCalorie.Gateway.Resolvers
{
    public class FoodResolver
    {
        private readonly HttpClient _httpClient;

        public FoodResolver(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<FoodDto>> GetFoodsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://localhost:8647/food/foods");
                response.EnsureSuccessStatusCode();
                var foods = await response.Content.ReadFromJsonAsync<IEnumerable<FoodDto>>();
                return foods;
            }
            catch(Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<FoodDto>();
            }
        }
        public async Task<FoodDto?> GetFoodByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://localhost:8647/food/foods/{id}");
                response.EnsureSuccessStatusCode();
                var food = await response.Content.ReadFromJsonAsync<FoodDto>();
                return food;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
