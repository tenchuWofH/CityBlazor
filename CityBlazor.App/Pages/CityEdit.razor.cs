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

        [Parameter]
        public string CityId { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public City EditedCity { get; set; } = new City();

        protected int MyProperty { get; set; }

        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected override async Task OnInitializedAsync()
        {
            Saved = false;

            int.TryParse(this.CityId, out var CityId);

            if (CityId == 0) //new City is being created
            {
                //add some defaults
                this.EditedCity = new City { CityId = 1, Name = "Default City", Description = "Some default description" };
            }
            else
            {
                this.EditedCity = await CityDataService.GetCityDetails(int.Parse(this.CityId));
            }

        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;

            if (this.EditedCity.CityId == 0) //new
            {
                var addedCity = await CityDataService.AddCity(this.EditedCity);
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
                await CityDataService.UpdateCity(this.EditedCity);
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
            await CityDataService.DeleteCity(this.EditedCity.CityId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/Cityoverview");
        }
    }
}

