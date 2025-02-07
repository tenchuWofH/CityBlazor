#pragma checksum "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33cc78f400980b11737efd5e8472f293895f752b"
// <auto-generated/>
#pragma warning disable 1591
namespace CityBlazorApp.Pages
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
#nullable restore
#line 3 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
using CityBlazorApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
using CityBlazor.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
using CityBlazor.Shared.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CityEdit/{CityId}")]
    public partial class CityEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 10 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
 if (!Saved)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "employee-edit");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "class", "page-title");
            __builder.AddContent(6, "Details for ");
            __builder.AddContent(7, 
#nullable restore
#line 13 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                            EditedCity.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                          EditedCity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                    HandleInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(15);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group row");
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.AddMarkupContent(22, "<label for=\"Name\" class=\"col-sm-3\">Name: </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "Name");
                __builder2.AddAttribute(25, "class", "form-control col-sm-8");
                __builder2.AddAttribute(26, "placeholder", "Enter name");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                                 EditedCity.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditedCity.Name = __value, EditedCity.Name))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditedCity.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __Blazor.CityBlazorApp.Pages.CityEdit.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, "offset-sm-3 col-sm-8", 33, 
#nullable restore
#line 21 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                       () => EditedCity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group row");
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.AddMarkupContent(39, "<label for=\"Description\" class=\"col-sm-3\">First name: </label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "id", "Description");
                __builder2.AddAttribute(42, "class", "form-control col-sm-8");
                __builder2.AddAttribute(43, "placeholder", "Enter description");
                __builder2.AddAttribute(44, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                                        EditedCity.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditedCity.Description = __value, EditedCity.Description))));
                __builder2.AddAttribute(46, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditedCity.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __Blazor.CityBlazorApp.Pages.CityEdit.TypeInference.CreateValidationMessage_1(__builder2, 48, 49, "offset-sm-3 col-sm-8", 50, 
#nullable restore
#line 27 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                       () => EditedCity.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n            ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row");
                __builder2.AddMarkupContent(55, "\r\n                ");
                __builder2.AddMarkupContent(56, "<label for=\"country\" class=\"col-sm-3\">Country: </label>\r\n                ");
                __Blazor.CityBlazorApp.Pages.CityEdit.TypeInference.CreateInputSelect_2(__builder2, 57, 58, "country", 59, "form-control col-sm-8", 60, 
#nullable restore
#line 32 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                                      CountryCode

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CountryCode = __value, CountryCode)), 62, () => CountryCode, 63, (__builder3) => {
                    __builder3.AddMarkupContent(64, "\r\n");
#nullable restore
#line 33 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                     foreach (var country in Countries)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(65, "                        ");
                    __builder3.OpenElement(66, "option");
                    __builder3.AddAttribute(67, "value", 
#nullable restore
#line 35 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                        country.Code

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(68, 
#nullable restore
#line 35 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                       country.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n");
#nullable restore
#line 36 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(70, "                ");
                }
                );
                __builder2.AddMarkupContent(71, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group row");
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.AddMarkupContent(76, "<label for=\"gender\" class=\"col-sm-3\">Capital?: </label>\r\n                ");
                __Blazor.CityBlazorApp.Pages.CityEdit.TypeInference.CreateInputSelect_3(__builder2, 77, 78, "IsCapital", 79, "form-control col-sm-8", 80, 
#nullable restore
#line 43 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                                       IsCapital

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => IsCapital = __value, IsCapital)), 82, () => IsCapital, 83, (__builder3) => {
                    __builder3.AddMarkupContent(84, "\r\n                    ");
                    __builder3.OpenElement(85, "option");
                    __builder3.AddAttribute(86, "value", 
#nullable restore
#line 44 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                     SimpleChoice.Nao

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(87, "Não");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(88, "\r\n                    ");
                    __builder3.OpenElement(89, "option");
                    __builder3.AddAttribute(90, "value", 
#nullable restore
#line 45 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                     SimpleChoice.Sim

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(91, "Sim");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n                ");
                }
                );
                __builder2.AddMarkupContent(93, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n\r\n            \r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.AddMarkupContent(97, "\r\n                ");
                __builder2.AddMarkupContent(98, "<label for=\"RegistrationDate\" class=\"col-sm-3\">Registred on: </label>\r\n                ");
                __Blazor.CityBlazorApp.Pages.CityEdit.TypeInference.CreateInputDate_4(__builder2, 99, 100, "RegistrationDate", 101, "form-control col-sm-8", 102, "Enter registration date", 103, 
#nullable restore
#line 52 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                                                             EditedCity.RegistrationDate

#line default
#line hidden
#nullable disable
                , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditedCity.RegistrationDate = __value, EditedCity.RegistrationDate)), 105, () => EditedCity.RegistrationDate);
                __builder2.AddMarkupContent(106, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n\r\n            ");
                __builder2.AddMarkupContent(108, "<button type=\"submit\" class=\"btn btn-primary edit-btn\">Save city</button>\r\n\r\n");
#nullable restore
#line 58 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
             if (EditedCity.CityId > 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(109, "                ");
                __builder2.OpenElement(110, "a");
                __builder2.AddAttribute(111, "class", "btn btn-danger");
                __builder2.AddAttribute(112, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                     DeleteCity

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(113, "\r\n                    Delete\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n");
#nullable restore
#line 63 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(115, "\r\n            ");
                __builder2.OpenElement(116, "a");
                __builder2.AddAttribute(117, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                                          NavigateToOverview

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(119, "Back to overview");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(121, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 68 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "    ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "alert" + " " + (
#nullable restore
#line 72 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                       StatusClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(126, 
#nullable restore
#line 72 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
                                     Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#nullable restore
#line 73 "D:\Pessoal\Projects\CityBlazor\CityBlazor.App\Pages\CityEdit.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.CityBlazorApp.Pages.CityEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
