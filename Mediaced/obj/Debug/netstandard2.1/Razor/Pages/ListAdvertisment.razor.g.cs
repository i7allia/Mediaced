#pragma checksum "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4f09c5dc209efd379a2a4f7fa339266dffcae54"
// <auto-generated/>
#pragma warning disable 1591
namespace Mediaced.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\project\Mediaced\Mediaced\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\project\Mediaced\Mediaced\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Mediaced;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Mediaced.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\project\Mediaced\Mediaced\_Imports.razor"
using Mediaced.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/list")]
    public partial class ListAdvertisment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"workblock\">\r\n    <div class=\"row\">\r\n    <div class=\"col-2\"></div>\r\n    <div class=\"col-8\"></div>\r\n    <h2>???????????? ????????????????????</h2>\r\n\r\n    </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    <div class=\"col-2\"></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, @"<thead>
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">???????????????????????? ????????????????</th>
                    <th scope=""col"">?????????? ???????????????? ????????????????</th>
                    <th scope=""col"">???????????????? ?? USD</th>
                    <th scope=""col"">????????</th>
                    <th scope=""col"">???????????????? ?? BYN</th>
                    
                    </tr>

            </thead>
            ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 28 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                 foreach (var x in advs)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "scope", "row");
            __builder.AddContent(18, 
#nullable restore
#line 31 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                                     x.id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                         x.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                         x.phonenumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                         x.salaryusd

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 35 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                         x.course

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 36 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                         x.salarybyn

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 38 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "                \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\project\Mediaced\Mediaced\Pages\ListAdvertisment.razor"
       
    public List<Advertisement> advs;
        protected override void OnInitialized()
        {
            base.OnInitialized();
        advs = new List<Advertisement>();
        Advertisement adv1 = new Advertisement(1, "??????????????????????", "+375297777777", 700, 2.6f, 1820f);

        advs.Add(adv1);

        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
