#pragma checksum "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91f53796d7be85482a101f9416085ae62ced0bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rental_Index), @"mvc.1.0.view", @"/Views/Rental/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91f53796d7be85482a101f9416085ae62ced0bb", @"/Views/Rental/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef66cc944c2b209137c1a66d68b9e5de1eee9b1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Rental_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RentDetailVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "car", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "rent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""hero inner-page"" >
        
  <div class=""container"">
    <div class=""row align-items-end "">
      <div class=""col-lg-5"">
        <div class=""intro"">
          <h1><strong>Icarə Detalları</strong></h1>
          <div class=""custom-breadcrumbs"">
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91f53796d7be85482a101f9416085ae62ced0bb5696", async() => {
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
            WriteLiteral("\r\n              <span class=\"mx-2\">/</span>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91f53796d7be85482a101f9416085ae62ced0bb7123", async() => {
                WriteLiteral("Avtomobil icarəsi");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              <span class=""mx-2"">/</span> 
              <strong>İcarə detalları</strong>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>


<div class=""site-section"">
    <div class=""container bg-light px-5 py-4"">
         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91f53796d7be85482a101f9416085ae62ced0bb8759", async() => {
                WriteLiteral("\r\n             <span class=\"text-danger fw-bold\">");
#nullable restore
#line 27 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
                                          Write(Html.ValidationMessage("Error"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n              <div class=\"row\">\r\n                   <div class=\"col-sm-7\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-6 form-group\">\r\n                               <input class=\"p-2\"");
                BeginWriteAttribute("value", " value=\"", 1107, "\"", 1131, 1);
#nullable restore
#line 32 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 1115, Model.User.Name, 1115, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                            <div class=""col-sm-6 form-group"">
                               <input class=""p-2""");
                BeginWriteAttribute("value", " value=\"", 1397, "\"", 1424, 1);
#nullable restore
#line 36 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 1405, Model.User.Surname, 1405, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6 form-group"">
                               <input class=""p-2""");
                BeginWriteAttribute("value", " value=\"", 1765, "\"", 1790, 1);
#nullable restore
#line 42 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 1773, Model.User.Email, 1773, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                            <div class=""col-sm-6 form-group"">
                               <input class=""p-2""");
                BeginWriteAttribute("value", " value=\"", 2056, "\"", 2087, 1);
#nullable restore
#line 46 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 2064, Model.User.PhoneNumber, 2064, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Telefon"" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6 form-group"">
                               <input class=""p-2""");
                BeginWriteAttribute("value", " value=\"", 2450, "\"", 2495, 2);
#nullable restore
#line 52 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 2458, Model.Car.Brand.Name, 2458, 21, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue(" ", 2479, Model.Car.Name, 2480, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                            <div class=""col-sm-6 form-group"">
                               <input class=""p-2""");
                BeginWriteAttribute("value", " value=\"", 2761, "\"", 2798, 2);
                WriteAttributeValue("", 2769, "&#8380;", 2769, 7, true);
#nullable restore
#line 56 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue(" ", 2776, Model.Car.DailyPrice, 2777, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"  id=""dailyPrice"" autocomplete=""off"" style=""width:75%;"" disabled>
                               <span class=""text-danger"" ></span>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6 form-group"">
                                <div id=""rentdatepicker"" class=""input-group date"" >
                                    <input class=""form-control"" name=""startDate"" id=""startDate"" type=""date"" />
                                    <input type=""hidden"" name=""carId""");
                BeginWriteAttribute("value", " value=\"", 3373, "\"", 3394, 1);
#nullable restore
#line 64 "C:\Users\HP\Desktop\Final Project\RentACarProject\CarRental\CarRental\CarRental\Views\Rental\Index.cshtml"
WriteAttributeValue("", 3381, Model.Car.Id, 3381, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n");
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-sm-6 form-group"">
                                <div id=""returndatepicker"" class=""input-group date"" >
                                    <input class=""form-control"" name=""endDate"" id=""endDate"" type=""date"" disabled/>
");
                WriteLiteral(@"                                </div>
                            </div>
                        </div>
                   </div>
                   <div class=""col-sm-1""></div>
                   <div class=""col-sm-4 pt-5"" style=""border:gray solid 1px;""> 
                       <div class=""row pt-4"">
                           <div class=""col-sm-9"">
                               <h5><strong>Icarə müddəti(gün):</strong></h5>
                           </div>
                           <div class=""col-sm-3"">
                               <p id=""dayCount"">0</p>
                           </div>
                       </div>
                       <div class=""row"">
                           <div class=""col-sm-9"">
                               <h5><strong>Icarə qiyməti:</strong></h5>
                           </div>
                           <div class=""col-sm-3"">
                               <p>&#8380; <span id=""totalPrice"">0</span></p>
                           </div>
            ");
                WriteLiteral(@"           </div>
                   </div>
              </div>
              <div class=""row pt-4"">
                  <div class=""col-sm-12 justify-content-center text-center text-light"">
                      <button type=""submit"" class=""btn btn-primary"" disabled id=""rentBtn"">Davam Et</button>
                  </div>      
              </div>
         ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
     <script>    
        //$(document).ready(function() {
        //    $(""#rentdatepicker"").datepicker({
        //        format: ""dd-M-yyyy"",
        //        todayHighlight: true,
        //        autoclose: true,
        //        clearBtn: true
        //    });
        //});

        //$(document).ready(function() {
        //    $(""#returndatepicker"").datepicker({
        //        format: ""dd-M-yyyy"",
        //        todayHighlight: true,
        //        autoclose: true,
        //        clearBtn: true
        //    });
        //});

         let startDate = document.getElementById(""startDate"")
         let endDate = document.getElementById(""endDate"")
         let dailyPrice = document.getElementById(""dailyPrice"")
         let dayCount = document.getElementById(""dayCount"")
         let totalPrice = document.getElementById(""totalPrice"")
         let rentBtn = document.getElementById(""rentBtn"")


         startDate.onchange=function(){
             endDate.removeA");
                WriteLiteral(@"ttribute(""disabled"")

         }
         endDate.onchange=function(){
             let date1= new Date(startDate.value)
             let date2= new Date(endDate.value)

             const diffTime = Math.abs(date2 - date1);
             const diffDays = Math.ceil(diffTime / (1000 * 60 * 60 * 24)); 
             dayCount.innerHTML=diffDays
             totalPrice.innerHTML=diffDays*dailyPrice.value.split("" "")[1]
             rentBtn.removeAttribute(""disabled"")
         }
     </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RentDetailVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
