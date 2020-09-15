using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CityBlazor.Shared.Models;

namespace CityBlazorApp.Services
{
    public class CityDataService : ICityDataService
    {
        private readonly HttpClient _httpClient;

        public CityDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<City> Add(City City)
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

        public async Task Update(City City)
        {
            var CityJson =
                new StringContent(JsonSerializer.Serialize(City), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/City", CityJson);
        }

        public async Task Delete(int CityId)
        {
            await _httpClient.DeleteAsync($"api/City/{CityId}");
        }

        public async Task<IEnumerable<City>> Get()
        {
            // return await _httpClient.GetFromJsonAsync<List<City>>("sample-data/cities.json");
    
            // return await JsonSerializer.DeserializeAsync<IEnumerable<City>>
            //         (await _httpClient.GetStreamAsync($"api/City"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return await JsonSerializer.DeserializeAsync<IEnumerable<City>>
                    (await _httpClient.GetStreamAsync("sample-data/cities.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<City> Get(int CityId)
        {
            //TODO: verificar, após incorporar a Api, se a busca pelo Id fica correta
            //////return await JsonSerializer.DeserializeAsync<City>
            //////    (await _httpClient.GetStreamAsync($"api/City/{CityId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            ////return await JsonSerializer.DeserializeAsync<City>
            ////    (await _httpClient.GetStreamAsync($"sample-data/cities.json/{CityId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //UriBuilder builder = new UriBuilder("https://localhost:44308/sample-data/cities.json");// { Scheme = Uri.UriSchemeHttps };
            //builder.Query = $"CityId={CityId}";

            ////var stream = (await _httpClient.GetStreamAsync(builder.Uri), new JsonSerializerOptions() { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });

            ////Create a query
            //try
            //{
            //    return await JsonSerializer.DeserializeAsync<City>
            //    (await _httpClient.GetStreamAsync(builder.Uri), new JsonSerializerOptions() { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });
            //}
            //catch (JsonException) // Invalid JSON
            //{
            //    Console.WriteLine("Invalid JSON.");
            //    return null;
            //}

            var cities = await Get();
            return cities.Where(x => x.CityId == CityId).FirstOrDefault();
        }

       
    }
}
