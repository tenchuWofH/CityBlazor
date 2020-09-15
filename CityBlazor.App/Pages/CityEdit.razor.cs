using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using CityBlazor.Shared.Models;
using CityBlazorApp.Services;

namespace CityBlazorApp.Pages
{
    //public partial class CityeEdit
    public partial class CityEdit : ComponentBase //BlazorComponent
    {
        [Inject]
        public ICityDataService CityDataService { get; set; }
        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        [Parameter]
        public string CityId { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public City EditedCity { get; set; } = new City();
        public List<Country> Countries { get; set; } = new List<Country>();
        //used because InputSelect (video explained)
        protected string CountryCode = string.Empty;
        protected string IsCapital = string.Empty;

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;
            Countries = (await CountryDataService.Get()).ToList();

            int.TryParse(this.CityId, out var CityId);

            if (CityId == 0) //new City is being created
            {
                //add some defaults
                this.EditedCity = new City { CityId = 1, Name = "Default City", RegistrationDate = DateTime.Now, Description = "Some default description", Country = new Country { Code = "", Name = "" }, IsCapital = false };//, PointsOfInterest = new List<PointOfInterest>().Add( new PointOfInterest { CityId = 1, Name = "", Description = "", PointOfInterestId = 1 } );
            }
            else
            {
                this.EditedCity = await CityDataService.Get(int.Parse(this.CityId));
            }
            CountryCode = EditedCity.Country.Code.ToString();
            IsCapital = EditedCity.IsCapital == false ? CityBlazor.Shared.Enums.SimpleChoice.Nao : CityBlazor.Shared.Enums.SimpleChoice.Sim;
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            EditedCity.Country.Code = CountryCode;

            if (this.EditedCity.CityId == 0) //new
            {
                var addedCity = await CityDataService.Add(this.EditedCity);
                if (addedCity != null)
                {
                    StatusClass = "alert-success";
                    Message = "New City added successfully.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new City. Please try again.";
                    Saved = false;
                }
            }
            else
            {
                await CityDataService.Update(this.EditedCity);
                StatusClass = "alert-success";
                Message = "City updated successfully.";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected async Task DeleteCity()
        {
            await CityDataService.Delete(this.EditedCity.CityId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/citylist");
        }
    }
}

