#pragma checksum "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0828ee0660ae45e3d29aa632c51d3e5f886a4e19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductsThatCostMoreThan), @"mvc.1.0.view", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
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
#line 1 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\_ViewImports.cshtml"
using NorthwindMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0828ee0660ae45e3d29aa632c51d3e5f886a4e19", @"/Views/Home/ProductsThatCostMoreThan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10324db967624bce2cebb2dbfaf1321bdbfb158", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_ProductsThatCostMoreThan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Packt.Shared.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
      
  string title =
    "Products That Cost More Than " + ViewData["MaxPrice"];
  ViewData["Title"] = title;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 7 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
   Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    <table class=""table"">
        <thead>
            <tr>
                <th>Category Name</th>
                <th>Supplier's Company Name</th>
                <th>Product Name</th>
                <th>Unit Price</th>
                <th>Units In Stock</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
             foreach (var item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
               Write(Html.DisplayFor(modelItem => item.Supplier.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\PracticalApps\NorthwindMvc\Views\Home\ProductsThatCostMoreThan.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n    </table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Packt.Shared.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591