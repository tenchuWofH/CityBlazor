using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CityBlazor.Models;

namespace CityBlazor.App.Services
{
    public class CityDataService : ICityDataService
    {
        private readonly HttpClient _httpClient;

        public CityDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<City> AddCity(City City)
        {
            var CityJson =
                new StringContent(JsonSerializer.Serialize(City), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/City", CityJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<City>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdateCity(City City)
        {
            var CityJson =
                new StringContent(JsonSerializer.Serialize(City), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/City", CityJson);
        }

        public async Task DeleteCity(int CityId)
        {
            await _httpClient.DeleteAsync($"api/City/{CityId}");
        }

        public async Task<IEnumerable<City>> GetAllCitys()
        {
            // return await _httpClient.GetFromJsonAsync<List<City>>("sample-data/cities.json");
    
            // return await JsonSerializer.DeserializeAsync<IEnumerable<City>>
            //         (await _httpClient.GetStreamAsync($"api/City"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return await JsonSerializer.DeserializeAsync<IEnumerable<City>>
                    (await _httpClient.GetStreamAsync("sample-data/cities.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<City> GetCityDetails(int CityId)
        {
            return await JsonSerializer.DeserializeAsync<City>
                (await _httpClient.GetStreamAsync($"api/City/{CityId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

       
    }
}
