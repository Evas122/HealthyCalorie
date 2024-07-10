using HealthyCalorie.Recipe.CrossCutting.Dtos;

namespace HealthyCalorie.Gateway.Resolvers
{
    public class RecipeResolver
    {
        private readonly HttpClient _httpClient;

        public RecipeResolver(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<RecipeDto>> GetRecipesAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("http://localhost:5071/recipe/recipes");
                response.EnsureSuccessStatusCode();
                var recipes = await response.Content.ReadFromJsonAsync<IEnumerable<RecipeDto>>();
                return recipes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return Enumerable.Empty<RecipeDto>();
            }
        }
        public async Task<RecipeDto?> GetRecipeByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"http://localhost:5071/recipe/recipes/{id}");
                response.EnsureSuccessStatusCode();
                var recipe = await response.Content.ReadFromJsonAsync<RecipeDto>();
                return recipe;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public async Task<bool> CreateRecipeAsync(RecipeDto dto)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("http://localhost:5071/recipe/recipes", dto);
                return response.IsSuccessStatusCode;
            }
            catch( Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public async Task<bool> DeleteRecipeAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"http://localhost:5071/recipe/recipes/{id}");
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
