#pragma checksum "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityList - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e410f79bc34fcf792fc9a3096a3e5b400b538b75"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CityBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityList - Copy.razor"
using CityBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CityList")]
    public partial class CityList___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityList - Copy.razor"
      
    private IList<City> cities;

    protected override async Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "d:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityList - Copy.razor"
                                                                                                     
        cities = await Http.GetFromJsonAsync<List<City>>("sample-data/cities.json");
    }

    

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
