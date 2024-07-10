using HealthyCalorie.UserFood.CrossCutting.Dtos;

namespace HealthyCalorie.Gateway.Resolvers
{
    public class UserFoodResolver
    {
        private readonly HttpClient _httpClient;

        public UserFoodResolver(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<UserFoodDto>> GetUserFoodsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://localhost:5268/userfood/userfoods");
                response.EnsureSuccessStatusCode();
                var userFoods = await response.Content.ReadFromJsonAsync<IEnumerable<UserFoodDto>>();
                return userFoods;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<UserFoodDto>();
            }
        }

        public async Task<UserFoodDto?> GetUserFoodByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://localhost:5268/userfood/userfoods/{id}");
                response.EnsureSuccessStatusCode();
                var userFood = await response.Content.ReadFromJsonAsync<UserFoodDto>();
                return userFood;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> DeleteUserFoodAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"http://localhost:5268/userfood/userfoods/{id}");
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

