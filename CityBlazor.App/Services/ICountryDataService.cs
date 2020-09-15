using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBlazor.Shared.Models;

namespace CityBlazorApp.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> Get();
        Task<Country> Get(string Code);
    }
}