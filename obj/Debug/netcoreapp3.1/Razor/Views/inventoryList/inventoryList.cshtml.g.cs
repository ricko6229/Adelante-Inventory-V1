#pragma checksum "C:\Users\ricko\OneDrive\Inventory Management System\Prototype\Adelante Inventory V1\Views\inventoryList\inventoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f7b74ee258186485c5568edc51e9bc90619307f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_inventoryList_inventoryList), @"mvc.1.0.view", @"/Views/inventoryList/inventoryList.cshtml")]
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
#line 1 "C:\Users\ricko\OneDrive\Inventory Management System\Prototype\Adelante Inventory V1\Views\_ViewImports.cshtml"
using Adelante_Inventory_V1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ricko\OneDrive\Inventory Management System\Prototype\Adelante Inventory V1\Views\_ViewImports.cshtml"
using Adelante_Inventory_V1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f7b74ee258186485c5568edc51e9bc90619307f", @"/Views/inventoryList/inventoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d7842ca98b9d113f6a7042ba080db36adc2415", @"/Views/_ViewImports.cshtml")]
    public class Views_inventoryList_inventoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f7b74ee258186485c5568edc51e9bc90619307f3443", async() => {
                WriteLiteral(@"
    <title>Dashboard- Manager</title>
    <style>
        /* Remove the navbar's default margin-bottom and rounded borders */
        .navbar {
            margin-bottom: 0;
            border-radius: 0;
        }

        /* Set height of the grid so .sidenav can be 100% (adjust as needed) */
        .row.content {
            height: 450px
        }

        /* Set gray background color and 100% height */
        .sidenav {
            padding-top: 20px;
            background-color: #f1f1f1;
            height: 100%;
        }

        /* Set black background color, white text and some padding */
        footer {
            background-color: #555;
            color: white;
            padding: 15px;
        }

        /* On small screens, set height to 'auto' for sidenav and grid */
        navbar-header {
            height: auto;
            padding: 15px;
        }

        .row.content {
            height: auto;
        }
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f7b74ee258186485c5568edc51e9bc90619307f5414", async() => {
                WriteLiteral(@"

    <nav class=""navbar navbar-inverse"">
        <div class=""container-fluid"">
            <div class=""navbar-header"">
                <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#myNavbar"">
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
                <a class=""navbar-brand"" href=""/Home"">Exit</a>
            </div>
            <div class=""collapse navbar-collapse"" id=""myNavbar"">
                <ul class=""nav navbar-nav"">
                    <li class=""active""><a href=""#"">Home</a></li>
                    <li><a href=""userManage"">User Management</a></li>
                    <li><a href=""inventoryList"">Inventory</a></li>
                    <li><a href=""Reports"">Reports</a></li>
                </ul>
                <ul class=""nav navbar-nav navbar-right"">
                    <li><a href=""#""><span class=""glyphicon glyphico");
                WriteLiteral(@"n-log-in""></span> Upload Document</a></li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""container-fluid text-center"">
        <div class=""container"">
            <div class=""jumbotron"">
                <h1>Welcome {username}</h1>
                <p>
                    Current Inventory List
                </p>
            </div>
            <table class=""table table-dark"">
                <thead>
                    <tr>
                        <th scope=""col"">#</th>
                        <th scope=""col"">First</th>
                        <th scope=""col"">Last</th>
                        <th scope=""col"">Handle</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope=""row"">1</th>
                        <td>Mark</td>
                        <td>Otto</td>
                        <td>mdo</td>
                    </tr>
                    <tr>
                ");
                WriteLiteral(@"        <th scope=""row"">2</th>
                        <td>Jacob</td>
                        <td>Thornton</td>
                        <td>fat</td>
                    </tr>
                    <tr>
                        <th scope=""row"">3</th>
                        <td>Larry</td>
                        <td>the Bird</td>
                        <td>twitter</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <footer class=""container-fluid text-center"">
        <p><span class=""glyphicon glyphicon-log-in""></span>Manage Inventory</p>
    </footer>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
