#pragma checksum "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b974919b5d8a1ee41e690c01942fd6f9a7861e16"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using BlazorUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHubRepos\Where-is-Fluffymon\UserService\BlazorUI\_Imports.razor"
using BlazorUI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<title>Register</title>\r\n\r\n<link rel=\"stylesheet\" href=\"css/login-register.css\">\r\n");
            __builder.OpenComponent<BlazorUI.Shared.BodyStyle>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<div class=\"signup-form\"><form action=\"some_action\" method=\"post\"><h2>Register</h2>\r\n        <div class=\"form-group\"><div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\"><span class=\"fa fa-user-circle\"></span></span></div>\r\n                <input type=\"text\" class=\"form-control\" name=\"first_name\" placeholder=\"First Name\" required=\"required\"></div></div>\r\n        <div class=\"form-group\"><div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\"><span class=\"fa fa-user-circle-o\"></span></span></div>\r\n                <input type=\"text\" class=\"form-control\" name=\"last_name\" placeholder=\"Last Name\" required=\"required\"></div></div>\r\n        <div class=\"form-group\"><div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\"><i class=\"fa fa-paper-plane\"></i></span></div>\r\n                <input type=\"email\" class=\"form-control\" name=\"email\" placeholder=\"Email Address\" required=\"required\"></div></div>\r\n        <div class=\"form-group\"><div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\"><i class=\"fa fa-unlock\"></i></span></div>\r\n                <input type=\"text\" class=\"form-control\" name=\"password\" placeholder=\"Password\" required=\"required\"></div></div>\r\n        <div class=\"form-group\"><div class=\"input-group\"><div class=\"input-group-prepend\"><span class=\"input-group-text\"><i class=\"fa fa-unlock\"></i></span></div>\r\n                <input type=\"text\" class=\"form-control\" name=\"confirm_password\" placeholder=\"Confirm Password\" required=\"required\"></div></div>\r\n        <div class=\"form-group\"><button type=\"submit\" class=\"btn btn-success btn-lg btn-block\">Register</button></div></form>\r\n    <div class=\"text-center\">\r\n        Already have an account? <a href=\"login\">Sign in</a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
