#pragma checksum "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4218576da3af3b78f4a36380c992ea6d1d21c3cf"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Client.Components
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
    public partial class TodoElement : TodoElementBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "role", "button");
            __builder.AddAttribute(2, "class", "list-group-item" + " list-group-item-action" + " flex-column" + " align-items-start" + " list-group-item-secondary" + " mb-1" + " " + (
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                                                                               string.Concat("bg-", Todo.Color)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "style", "cursor: pointer");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                                                                                                                                                     async () => await OnDetailsClick.InvokeAsync()

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "class", "mb-1");
            __builder.AddAttribute(7, "type", "checkbox");
            __builder.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                        async () => await UpdateStatus()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(9, "onclick", 
#nullable restore
#line 5 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                                                                                     true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                               Todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Todo.IsDone = __value, Todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "d-flex w-100 justify-content-between");
            __builder.OpenElement(15, "h5");
            __builder.AddAttribute(16, "class", "mb-1");
#nullable restore
#line 8 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
             if (Todo.IsDone)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "del");
#nullable restore
#line 10 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
__builder.AddContent(18, Todo.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
__builder.AddContent(19, Todo.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                           
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "close");
            __builder.AddAttribute(24, "aria-label", "Delete");
            __builder.AddAttribute(25, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                            async () => await DeleteTodo()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventStopPropagationAttribute(26, "onclick", 
#nullable restore
#line 17 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
                                                                                                                                       true

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "<span class=\"oi oi-trash\" aria-hidden=\"true\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "d-flex flex-column");
#nullable restore
#line 22 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
         if (!string.IsNullOrWhiteSpace(Todo.Description))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "p");
            __builder.AddAttribute(32, "class", "mb-1 text-break");
#nullable restore
#line 25 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
__builder.AddContent(33, Todo.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "d-flex flex-column");
#nullable restore
#line 29 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
             if ((DateTime.Now - Todo.DateAdded).TotalMinutes <= 30 && !Todo.IsDone)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<small class=\"text-success\"> (New)</small>");
#nullable restore
#line 32 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "small");
            __builder.AddAttribute(38, "class", "mt-2");
            __builder.AddContent(39, "Created ");
#nullable restore
#line 33 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
__builder.AddContent(40, Todo.DateAdded);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
     if (UpdateFailed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<p class=\"text-danger\">Status update failed, try again later</p>");
#nullable restore
#line 41 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
     if (DeleteFailed)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<p class=\"text-danger\">Delete failed, try again later</p>");
#nullable restore
#line 46 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\TodoElement.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
