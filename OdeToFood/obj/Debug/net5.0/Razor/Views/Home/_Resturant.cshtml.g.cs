#pragma checksum "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fe9a4f10869572ef3763bb370c46a70fe72926e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Resturant), @"mvc.1.0.view", @"/Views/Home/_Resturant.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\_ViewImports.cshtml"
using OdeToFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe9a4f10869572ef3763bb370c46a70fe72926e", @"/Views/Home/_Resturant.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c22902c138d4ea6089f81a88ca2389276a7ed32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Resturant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RestaurantListView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"restaurantList\">\r\n");
#nullable restore
#line 4 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4>");
#nullable restore
#line 7 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <div>");
#nullable restore
#line 8 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
            Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 8 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
                        Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div>Number of reviews: ");
#nullable restore
#line 9 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
                               Write(item.CountOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <hr />\r\n        </div>\r\n");
#nullable restore
#line 12 "C:\Users\serge\source\repos\OdeToFood\OdeToFood\Views\Home\_Resturant.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RestaurantListView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
