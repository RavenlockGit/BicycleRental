using BicycleRental.Shared.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BicycleRental.Client.Repositories
{
    public class BicycleRepository
    {

        private HttpClient _httpClient;
        private JsonSerializerOptions _jsonSerializerOptions;
        public BicycleRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("public-client");
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public Task Create(Bicycle bicycle)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Bicycle> Details(int id)
        {
            string requestUrl = $"api/Bicycles/Details/{id}";
            return await _httpClient.GetFromJsonAsync<Bicycle>(requestUrl, _jsonSerializerOptions);
        }

        public Task Edit(int id, Bicycle bicycle)
        {
            throw new NotImplementedException();
        }

        public async Task<Bicycle[]> Index()
        {
            string requestUrl = "api/Bicycles";
            return await _httpClient.GetFromJsonAsync<Bicycle[]>(requestUrl, _jsonSerializerOptions);
        }

        public async Task<Bicycle[]> Search(BicycleFilter filter)
        {
            string requestUrl = $"api/Bicycles/Search";

            return await _httpClient.GetFromJsonAsync<Bicycle[]>(requestUrl, _jsonSerializerOptions);

        }
    }
}
