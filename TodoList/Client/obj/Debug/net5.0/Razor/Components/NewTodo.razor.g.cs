#pragma checksum "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "108298e0de7856b5ccfe00a5972ad40a0ddc0b18"
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
    public partial class NewTodo : NewTodoBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
                  TodoForCreation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
                                                    async () => await CreateTodo()

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\n\n    ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "d-flex form-group");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", (object)("form-control mr-2 bg-dark text-white"));
                __builder2.AddAttribute(10, "placeholder", (object)("Add task"));
                __builder2.AddAttribute(11, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 7 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
                                TodoForCreation.Title

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(12, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TodoForCreation.Title = __value, TodoForCreation.Title)))));
                __builder2.AddAttribute(13, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => TodoForCreation.Title)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.AddMarkupContent(15, "<button class=\"btn btn-primary\" type=\"submit\">Add</button>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n    ");
                global::__Blazor.TodoList.Client.Components.NewTodo.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 10 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
                              () => TodoForCreation.Title

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 15 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
 if (TodoAlreadyExists)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<p class=\"text-danger\">Todo with this title already exists in this list</p>");
#nullable restore
#line 18 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
}
else if (CreationFailed)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p class=\"text-danger\">Something went wrong, try again later</p>");
#nullable restore
#line 22 "C:\Users\Sagg\Desktop\TodoList-master\TodoList\Client\Components\NewTodo.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.TodoList.Client.Components.NewTodo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
