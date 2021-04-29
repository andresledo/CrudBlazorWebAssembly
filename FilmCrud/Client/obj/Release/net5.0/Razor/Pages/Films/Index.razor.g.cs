#pragma checksum "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b1660fce479fbaac61afa7134fc1ee570f14e19"
// <auto-generated/>
#pragma warning disable 1591
namespace FilmCrud.Client.Pages.Films
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using FilmCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "G:\Ejemplos\FilmCrud\FilmCrud\Client\_Imports.razor"
using FilmCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
using FilmCrud.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/films")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Películas</h3>");
#nullable restore
#line 8 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
 if (_films == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Cargando...</em></p>");
#nullable restore
#line 11 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Id</th>\r\n                <th>Title</th>\r\n                <th>Description</th>\r\n                <th>Duration</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 25 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
             foreach (var film in _films)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 28 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                         film.Id.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 29 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                         film.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 30 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                         film.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 31 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                         film.Duration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                                          (() => Edit(film.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                            Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                                          (() => Delete(film.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "\r\n                            Delete\r\n                        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-success");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
                                                  Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "Añadir película");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "G:\Ejemplos\FilmCrud\FilmCrud\Client\Pages\Films\Index.razor"
       
    

    private List<Film> _films;

    protected override async Task OnInitializedAsync()
    {
        _films = await Http.GetFromJsonAsync<List<Film>>("/api/Films");
    }

    private async Task Delete(int id)
    {
        await Http.DeleteAsync($"/api/Films/{id}");
        _films = await Http.GetFromJsonAsync<List<Film>>("/api/Films");
        StateHasChanged();
    }

    private void Edit(int id)
    {
        Navigation.NavigateTo($"/film/edit/{id}");
    }

    private void Create()
    {
        Navigation.NavigateTo("/film/create");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
