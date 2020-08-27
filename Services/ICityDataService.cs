using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBlazor.Models;

namespace CityBlazor.App.Services
{
    public interface ICityDataService
    {
        Task<IEnumerable<City>> GetAllCitys();
        Task<City> GetCityDetails(int CityId);
        Task<City> AddCity(City City);
        Task UpdateCity(City City);
        Task DeleteCity(int CityId);
    }
}