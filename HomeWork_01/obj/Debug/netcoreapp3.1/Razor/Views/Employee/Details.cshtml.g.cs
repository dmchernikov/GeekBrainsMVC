#pragma checksum "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a004595d18fa816bdcb1d6177a44d13c08d0b71b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\_ViewImports.cshtml"
using HomeWork_01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\_ViewImports.cshtml"
using HomeWork_01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a004595d18fa816bdcb1d6177a44d13c08d0b71b", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"466ef0dfe03bd9178ab3e284f0704bb51041a43b", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeWork_01.Models.ViewModelEmployee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h4>Данные о сотруднике</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 8 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 11 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MidleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.MidleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
       Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
Write(Html.ActionLink("Список сотрудников", "List", "Employee"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <br />\r\n    ");
#nullable restore
#line 43 "C:\VS2019\GeekBrainsMVC\HomeWork_01\Views\Employee\Details.cshtml"
Write(Html.ActionLink("На главную страницу", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeWork_01.Models.ViewModelEmployee> Html { get; private set; }
    }
}
#pragma warning restore 1591