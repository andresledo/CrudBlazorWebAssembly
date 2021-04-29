// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
