#pragma checksum "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3bbaca45dc3826df534a9afbdf8acfbd95b110"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using TodoList.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using TodoList.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using TodoList.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using TodoList.Client.Components.Modals;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\_Imports.razor"
using TodoList.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
using TodoList.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Home : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card text-center mt-4");
#nullable restore
#line 12 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
     if (_loading)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div class=\"spinner-border spinner-border-sm\"></div>");
#nullable restore
#line 15 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "h4");
            __builder.AddAttribute(4, "class", "card-header text-white");
            __builder.AddAttribute(5, "style", "background: #052767;");
            __builder.AddContent(6, "Welcome ");
#nullable restore
#line 18 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
__builder.AddContent(7, _userName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body text-center");
#nullable restore
#line 20 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
             if (AppState.NumberOfAllIncompletedTodos == null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div class=\"spinner-border spinner-border-sm\"></div>");
#nullable restore
#line 23 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
            }
            else if (!AppState.ListsOfTodos.Any() && AppState.NumberOfAllIncompletedTodos == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<strong>You don\'t have any lists, create a new one using the side menu</strong>");
#nullable restore
#line 27 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "h4");
            __builder.AddContent(15, "You have ");
#nullable restore
#line 30 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
__builder.AddContent(16, AppState.NumberOfAllIncompletedTodos);

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, " undone todos");
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Pages\Home.razor"
       

    private bool _loading;
    private string _userName;

    protected override void OnInitialized()
    {
        _loading = true;
        _userName = AuthenticationService.User.Username;
        _loading = false;

        AppState.OnListsUpdate += StateHasChanged;

    }

    public void Dispose()
    {
        AppState.OnListsUpdate -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoListsService TodoListsService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationService AuthenticationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppStateContainer AppState { get; set; }
    }
}
#pragma warning restore 1591
