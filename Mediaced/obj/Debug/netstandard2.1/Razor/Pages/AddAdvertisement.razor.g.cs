#pragma checksum "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ba26501f761ee079cc3b7329e1900c66de41a5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class AddAdvertisement : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"workblock\">\r\n    <div class=\"row\">\r\n        <div class=\"col-2\"></div>\r\n        <div class=\"col-8\"></div>\r\n        <h2>???????????????? ????????????????????</h2>\r\n\r\n    </div>\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    <div class=\"col-2\"></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddMarkupContent(8, "\r\n\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group row");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label for=\"id\" class=\"col-sm-3 col-form-label\">ID</label>\r\n\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-sm-9");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "tupe", "text");
            __builder.AddAttribute(18, "readonly", true);
            __builder.AddAttribute(19, "class", "form-control-plaintext");
            __builder.AddAttribute(20, "id", "id");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
                                  adv.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adv.id = __value, adv.id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group row");
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.AddMarkupContent(29, "<label for=\"name\" class=\"col-sm-3 col-form-label\">???????????????????????? ????????????????</label>\r\n\r\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-9");
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "tupe", "text");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "id", "name");
            __builder.AddAttribute(37, "required", true);
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
                                  adv.name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adv.name = __value, adv.name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-group row");
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<label for=\"salaryusd\" class=\"col-sm-3 col-form-label\">???????????????? ?? USD</label>\r\n\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-sm-9");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "tupe", "text");
            __builder.AddAttribute(52, "class", "form-control");
            __builder.AddAttribute(53, "id", "salaryusd");
            __builder.AddAttribute(54, "required", true);
            __builder.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
                                  adv.salaryusd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adv.salaryusd = __value, adv.salaryusd));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group row");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.AddMarkupContent(63, "<label for=\"course\" class=\"col-sm-3 col-form-label\">???????? ????????</label>\r\n\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "col-sm-9");
            __builder.AddMarkupContent(66, "\r\n                    ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "tupe", "text");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "id", "course");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
                                  course

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => course = __value, course));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\r\n            ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "form-group row");
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.AddMarkupContent(79, "<label for=\"salarybyn\" class=\"col-sm-3 col-form-label\">???????????????? ?? BYN</label>\r\n\r\n                ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "col-sm-9");
            __builder.AddMarkupContent(82, "\r\n                    ");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "tupe", "text");
            __builder.AddAttribute(85, "class", "form-control");
            __builder.AddAttribute(86, "id", "salarybyn");
            __builder.AddAttribute(87, "value", 
#nullable restore
#line 53 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
                                                                                    getsalarybyn()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n            ");
            __builder.AddMarkupContent(91, "<button class=\"btn btn-primary\" type=\"submit\">??????????????????</button>\r\n\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\project\Mediaced\Mediaced\Pages\AddAdvertisement.razor"
               

            Advertisement adv;
            String phonenumber;
            String name;
            float salaryusd;
            float course;
            float salarybyn;


            protected override void OnInitialized()
            {
                base.OnInitialized();
                adv = new Advertisement();
                course = 2.9f;
            }
            private float getsalarybyn()
            {
                adv.salarybyn = adv.salaryusd * course;
                return adv.salarybyn;
            }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
