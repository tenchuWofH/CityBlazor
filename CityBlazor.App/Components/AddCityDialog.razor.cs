using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using CityBlazor.Shared.Models;
using CityBlazorApp.Services;

namespace CityBlazorApp.Components
{
    //public partial class CityeEdit
    public partial class AddCityDialog
    {
        [Inject]
        public ICityDataService CityDataService { get; set; }
        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        public City NewCity { get; set; } = new City { CityId = 1, Name = "Default City", RegistrationDate = DateTime.Now, Description = "Some default description", Country = new Country { Code = "", Name = "" }, IsCapital = false };//, PointsOfInterest = new List<PointOfInterest>().Add( new PointOfInterest { CityId = 1, Name = "", Description = "", PointOfInterestId = 1 } );
        public List<Country> Countries { get; set; } = new List<Country>();
        //used because InputSelect (video explained)
        protected string CountryCode = string.Empty;
        protected string IsCapital = string.Empty;

        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            NewCity = new City { CityId = 1, Name = "Default City", RegistrationDate = DateTime.Now, Description = "Some default description", Country = new Country { Code = "", Name = "" }, IsCapital = false };//, PointsOfInterest = new List<PointOfInterest>().Add( new PointOfInterest { CityId = 1, Name = "", Description = "", PointOfInterestId = 1 } );
        }

        protected async Task HandleValidSubmit()
        {
            await CityDataService.Add(NewCity);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}

