using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBlazor.Shared.Models;
using CityBlazor.App.Services;

namespace CityBlazor.App.Pages
{
    public partial class CityeEdit
    {
        [Inject]
        public ICityDataService CityDataService { get; set; }
        
        [Parameter]
        public string CityId { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public City City { get; set; } = new City();
        
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
                City = new City { CityId = 1, Name = "Default City", Description = "Some default description" };
            }
            else
            {
                City = await CityDataService.GetCityDetails(int.Parse(this.CityId));
            }

       }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            
            if (City.CityId == 0) //new
            {
                var addedCity = await CityDataService.AddCity(this.City);
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
                await CityDataService.UpdateCity(this.City);
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
            await CityDataService.DeleteCity(this.City.CityId);

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
