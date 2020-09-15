using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBlazor.Shared.Models;

namespace CityBlazorApp.Services
{
    public interface ICityDataService
    {
        Task<IEnumerable<City>> Get();
        Task<City> Get(int CityId);
        Task<City> Add(City City);
        Task Update(City City);
        Task Delete(int CityId);
    }
}