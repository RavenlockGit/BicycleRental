using BicycleRental.Shared.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BicycleRental.Client.Repositories
{
    public class ReservationRepository
    {
        private HttpClient _httpClient;
        private JsonSerializerOptions _jsonSerializerOptions;
        public ReservationRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("public-client");
            _jsonSerializerOptions = new JsonSerializerOptions()
            {
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }

        public async Task<string> Create(Reservation reservation)
        {
            string requestUrl = $"api/Reservations/Create";

            var res = await _httpClient.PostAsJsonAsync(requestUrl, reservation, _jsonSerializerOptions);
            if (!res.IsSuccessStatusCode)
            {
                return res.StatusCode.ToString();
            }
            else
            {
                return string.Empty;
            }

        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> Details(int id)
        {
            throw new NotImplementedException();
        }

        public Task Edit(int id, Reservation t)
        {
            throw new NotImplementedException();
        }

        public async Task<Reservation[]> Index(int bicycleId)
        {
            string requestUrl = $"api/Reservations/{bicycleId}";
            return await _httpClient.GetFromJsonAsync<Reservation[]>(requestUrl, _jsonSerializerOptions);
        }
    }
}
