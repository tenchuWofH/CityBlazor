#pragma checksum "d:\Pessoal\Projects\NetCore\CityBlazor\Pages\CityList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28895cd6de02e1bf3f7690b37eb5e741254d5c11"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CityBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using CityBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\Pessoal\Projects\NetCore\CityBlazor\_Imports.razor"
using CityBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\Pessoal\Projects\NetCore\CityBlazor\Pages\CityList.razor"
using CityBlazor.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CityList")]
    public partial class CityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "d:\Pessoal\Projects\NetCore\CityBlazor\Pages\CityList.razor"
      
    private IList<City> cities;

    protected override async Task OnInitializedAsync()
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "d:\Pessoal\Projects\NetCore\CityBlazor\Pages\CityList.razor"
                                                                                                     
        cities = await Http.GetFromJsonAsync<List<City>>("sample-data/cities.json");
    }

    

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
