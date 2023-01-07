using BicycleRental.Shared.Models;
using System.Net.Http.Json;

namespace BicycleRental.Client.Repositories
{
    public class BicycleRepository
    {

        private HttpClient _httpClient;
        private System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;
        public BicycleRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("public-client");
            _jsonSerializerOptions = new System.Text.Json.JsonSerializerOptions()
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve,
                PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase
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

            var a = await _httpClient.GetFromJsonAsync<Bicycle>(requestUrl, _jsonSerializerOptions);
            return a;
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
    }
}
