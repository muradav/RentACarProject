#pragma checksum "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b587056df331938214d8c11601a67214676b306"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b587056df331938214d8c11601a67214676b306", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b80ee057bf40b8fb1307e17e6898dc63f281f798", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""hero inner-page"">
        
        <div class=""container"">
          <div class=""row align-items-end "">
            <div class=""col-lg-5"">

              <div class=""intro"">
                <h1><strong>Haqqımızda</strong></h1>
                <div class=""custom-breadcrumbs"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b587056df331938214d8c11601a67214676b3065384", async() => {
                WriteLiteral("Əsas səhifə");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <span class=""mx-2"">/</span> <strong>Haqqımızda</strong></div>
              </div>

            </div>
          </div>
        </div>
      </div>

    

    <div class=""site-section"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-lg-6 mb-5 mb-lg-0 order-lg-2"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3b587056df331938214d8c11601a67214676b3067083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 710, "~/assets/images/", 710, 16, true);
#nullable restore
#line 26 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 726, Model.Abouts.FirstOrDefault().ImageUrl, 726, 39, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n          <div class=\"col-lg-4 mr-auto\">\r\n            <h2>");
#nullable restore
#line 29 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
           Write(Model.Abouts.FirstOrDefault().Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 30 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
          Write(Model.Abouts.FirstOrDefault().HeaderDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
          Write(Model.Abouts.FirstOrDefault().Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
          </div>
        </div>
      </div>
    </div>

    <div class=""site-section bg-light"">
      <div class=""container"">
        <div class=""row justify-content-center text-center mb-5 section-2-title"">
          <div class=""col-md-6"">
            <h2 class=""mb-4"">Komandamız</h2>
          </div>
        </div>
        <div class=""row align-items-stretch"">

");
#nullable restore
#line 46 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
           foreach (var item in Model.Teams)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div class=\"col-lg-4 col-md-6 mb-5\">\r\n            <div class=\"post-entry-1 h-100 person-1\">\r\n              \r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1622, "\"", 1657, 2);
            WriteAttributeValue("", 1628, "/assets/images/", 1628, 15, true);
#nullable restore
#line 51 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
WriteAttributeValue("", 1643, item.ImageUrl, 1643, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\"\r\n                 class=\"img-fluid\">\r\n            \r\n              <div class=\"post-entry-1-contents\">\r\n                <span class=\"meta\">");
#nullable restore
#line 55 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
                              Write(item.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <h2>");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
                          Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            WriteLiteral("              </div>\r\n            </div>\r\n          </div>\n");
#nullable restore
#line 61 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\About\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n      </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
