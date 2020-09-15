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
    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient _httpClient;

        public CountryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Country>> Get()
        {
            // return await _httpClient.GetFromJsonAsync<List<Country>>("sample-data/cities.json");
    
            // return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>
            //         (await _httpClient.GetStreamAsync($"api/Country"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>
                    (await _httpClient.GetStreamAsync("sample-data/countries.json"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Country> Get(string Code)
        {
            //TODO: verificar, após incorporar a Api, se a busca pelo Id fica correta
            //////return await JsonSerializer.DeserializeAsync<Country>
            //////    (await _httpClient.GetStreamAsync($"api/Country/{CountryId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            ////return await JsonSerializer.DeserializeAsync<Country>
            ////    (await _httpClient.GetStreamAsync($"sample-data/cities.json/{CountryId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            //UriBuilder builder = new UriBuilder("https://localhost:44308/sample-data/cities.json");// { Scheme = Uri.UriSchemeHttps };
            //builder.Query = $"CountryId={CountryId}";

            ////var stream = (await _httpClient.GetStreamAsync(builder.Uri), new JsonSerializerOptions() { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });

            ////Create a query
            //try
            //{
            //    return await JsonSerializer.DeserializeAsync<Country>
            //    (await _httpClient.GetStreamAsync(builder.Uri), new JsonSerializerOptions() { IgnoreNullValues = true, PropertyNameCaseInsensitive = true });
            //}
            //catch (JsonException) // Invalid JSON
            //{
            //    Console.WriteLine("Invalid JSON.");
            //    return null;
            //}

            var cities = await Get();
            return cities.Where(x => x.Code == Code).FirstOrDefault();
        }

       
    }
}
