#pragma checksum "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "888e103d35f94b3c554305fa9c627b95b124880d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Type2), @"mvc.1.0.view", @"/Views/Home/Type2.cshtml")]
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
#line 1 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\_ViewImports.cshtml"
using MultiplicationTable;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\_ViewImports.cshtml"
using MultiplicationTable.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"888e103d35f94b3c554305fa9c627b95b124880d", @"/Views/Home/Type2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db41931e3221e991d385b1a19eb1a40727384bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Type2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
  
    ViewData["Title"] = "Type2";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table-responsive-lg py-5\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 11 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                 for (int i = 1; i <= 12; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"col\">");
#nullable restore
#line 13 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 14 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 18 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
             for (int i = 2; i <= 12; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
#nullable restore
#line 21 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                     for (int j = 1; j <= 12; j++)
                    {
                        if (j == 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <th scope=\"row\">");
#nullable restore
#line 25 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                                        Write(j*i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 26 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td scope=\"row\">");
#nullable restore
#line 29 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                                        Write(j*i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 30 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 33 "C:\MYSTART-UP2020\GitHub\Multiplication-Table-.Net-Core\MultiplicationTable\MultiplicationTable\Views\Home\Type2.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
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
