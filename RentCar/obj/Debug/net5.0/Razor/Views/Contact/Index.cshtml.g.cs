#pragma checksum "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b1149f3bc0d8330c740e5dec9d1dbade021f876"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.ViewModels.Car;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\RentCar\RentCar\Views\_ViewImports.cshtml"
using RentCar.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1149f3bc0d8330c740e5dec9d1dbade021f876", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59446d1e6eb512a4da9c02bd3c686a7f8f6276b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--==================== FORM START ====================-->\r\n<div class=\"form__container\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b1149f3bc0d8330c740e5dec9d1dbade021f8764537", async() => {
                WriteLiteral(@"
        <div class=""form-header"">
            <h1>Bizimlə Əlaqə</h1>
        </div>
        <ul class=""form-ul"">
            <li>
                <label class=""form-lbl"" for=""name""><span>Ad <span class=""required-star"">*</span></span></label>
                <input class=""form-inp"" type=""text"" id=""name"" name=""user_name"">
            </li>
            <li>
                <label class=""form-lbl"" for=""surname""><span>Soyad <span class=""required-star"">*</span></span></label>
                <input class=""form-inp"" type=""text"" id=""surname"" name=""user_surname"">
            </li>
            <li>
                <label class=""form-lbl"" for=""mail""><span>Email <span class=""required-star"">*</span></span></label>
                <input class=""form-inp"" type=""email"" id=""mail"" name=""user_email"">
            </li>
            <li>
                <label class=""form-lbl"" for=""phone""><span>Telefon <span class=""required-star"">*</span></span></label>
                <input class=""form-inp"" type=""tel"" id=""pho");
                WriteLiteral(@"ne"" name=""user_phone"">
            </li>
            <li>
                <label class=""form-lbl"" for=""msg""><span>Mesaj</span></label>
                <textarea class=""form-textarea"" rows=""4"" cols=""50""></textarea>
            </li>
            <li>
                <input id=""form-submit-btn"" type=""submit"" value=""Göndər"">
            </li>
        </ul>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<!--==================== FORM END ====================-->\r\n\r\n\r\n<!--==================== MAP ADDRESS START ====================-->\r\n<div class=\"address__container\">\r\n\r\n    <div class=\"item\">\r\n        <div class=\"address\">\r\n            <h1>");
#nullable restore
#line 50 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
           Write(Model.Address.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 50 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
                               Write(Model.Address.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p>");
#nullable restore
#line 51 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
          Write(Model.Address.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Tel: ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
               Write(Model.Address.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 52 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
                                            Write(Model.Address.MobileNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a href=\"https://www.instagram.com/vasifcoder/\">");
#nullable restore
#line 53 "C:\Users\HP\Desktop\RentCar\RentCar\Views\Contact\Index.cshtml"
                                                       Write(Model.Address.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        </div>
    </div>


    <div class=""item"">
        <div class=""map"">
            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.4286744962415!2d49.85175681535471!3d40.3771908793697!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d079efb5163%3A0xc20aa51a5f0b5e01!2sCode%20Academy!5e0!3m2!1sen!2s!4v1647447611196!5m2!1sen!2s"" width=""600"" height=""450"" style=""border:0;""");
            BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 2524, "\"", 2542, 0);
            EndWriteAttribute();
            WriteLiteral(" loading=\"lazy\"></iframe>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<!--==================== MAP ADDRESS END ====================-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
