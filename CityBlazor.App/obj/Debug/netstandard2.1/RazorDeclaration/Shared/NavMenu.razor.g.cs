#pragma checksum "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657a4535450399b25a27b8d186bc411f51fc0630"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CityBlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\_Imports.razor"
using CityBlazorApp.Components;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
