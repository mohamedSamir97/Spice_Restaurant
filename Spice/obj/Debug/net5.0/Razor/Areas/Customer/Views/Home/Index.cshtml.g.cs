#pragma checksum "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b473b2d061d322b3170ee8cef5f82430746cff47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\_ViewImports.cshtml"
using Spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b473b2d061d322b3170ee8cef5f82430746cff47", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7335b01999e594613dc7a9e8537178e45df8cec7", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Spice.Models.ViewModels.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ThumbnailAreaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n\r\n");
#nullable restore
#line 5 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
 if (Model.Coupon.ToList().Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"border\">\r\n        <div class=\"carousel\" data-ride=\"carousel\" data-interval=\"1500\">\r\n");
#nullable restore
#line 9 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
             for (int i = 0; i < Model.Coupon.Count(); i++)
            {
                if (i == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n\r\n");
#nullable restore
#line 15 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64); ;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 662, "\"", 675, 1);
#nullable restore
#line 19 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 668, imgsrc, 668, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n\r\n                    </div>\r\n");
#nullable restore
#line 22 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }

                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item \">\r\n\r\n");
#nullable restore
#line 28 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                          
                            var base64 = Convert.ToBase64String(Model.Coupon.ToList()[i].Picture);
                            var imgsrc = string.Format("data:image/jpg;base64,{0}", base64); ;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 1140, "\"", 1153, 1);
#nullable restore
#line 32 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1146, imgsrc, 1146, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50px\" class=\"d-block w-100\" />\r\n\r\n                    </div>\r\n");
#nullable restore
#line 35 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
            WriteLiteral("    <br />\r\n    <br />\r\n");
            WriteLiteral("    <div class=\"backgroundWhite container\">\r\n\r\n        <ul id=\"menu-filters\" class=\"menu-filter-list list-inline text-center \">\r\n\r\n            <li class=\"filter active btn btn-secondary ml-1 mr-1\" data-filter=\".menu-restaurant\">Show All</li>\r\n\r\n");
#nullable restore
#line 52 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
             foreach (var item in Model.Category)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"filter ml-1 mr-1\" data-filter=\".");
#nullable restore
#line 54 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                      Write(item.Name.Replace(" ",string.Empty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 54 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n\r\n");
#nullable restore
#line 60 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
         foreach (var category in Model.Category)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\" id=\"menu-wrapper\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b473b2d061d322b3170ee8cef5f82430746cff479318", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 64 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.MenuItem.Where(u=>u.Category.Name.Equals(category.Name));

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n");
#nullable restore
#line 67 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 71 "D:\programming courses\1 Projects\Spice restaurant\Spice\Spice\Areas\Customer\Views\Home\Index.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b473b2d061d322b3170ee8cef5f82430746cff4711560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      
    <script>
        var posts = $('.post');
        (function ($) { 
            $(""#menu-filters li"").click(function () {
                $(""#menu-filters li"").removeClass('active btn btn-secondary');
                $(this).addClass('active btn btn-secondary');

                var selectedFilter = $(this).data(""filter"");
                $("".menu-restaurant"").fadeOut();

                setTimeout(function () {
                    $(selectedFilter).slideDown();
                }, 300);
            });
        })(jQuery);
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Spice.Models.ViewModels.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
