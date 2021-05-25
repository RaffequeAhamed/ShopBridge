#pragma checksum "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114ccc3a491c2fc33f66555c6aa6517faaa3e3b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductEditorPage), @"mvc.1.0.view", @"/Views/Home/ProductEditorPage.cshtml")]
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
#line 1 "D:\SampleProjects\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SampleProjects\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SampleProjects\ShopBridge\Views\_ViewImports.cshtml"
using ShopBridge.Framework.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114ccc3a491c2fc33f66555c6aa6517faaa3e3b7", @"/Views/Home/ProductEditorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"696a1286cbe229aca51548db14e9e5c68b486732", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductEditorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productEditor-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("POST"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .input-validation-error {\r\n        border-color: #f86c6b;\r\n    }\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "114ccc3a491c2fc33f66555c6aa6517faaa3e3b75335", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 12 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
Write(Html.HiddenFor(m => m.ProductID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
Write(Html.HiddenFor(m => m.Mode));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 14 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
Write(Html.HiddenFor(m => m.ProductManufacturedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""animated fadein col-md-12 p-a-0 m-a-0"">
        <div class=""col-md-12"">
            <div class=""card-block p-a-0"">
                <div class=""row"">
                </div>
                <div class=""form-group"">
                    <div class=""input-group col-md-12"">
                        ");
#nullable restore
#line 22 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.LabelFor(m => m.ProductName, htmlAttributes: new { @class = "col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.TextBoxFor(m => m.ProductName, htmlAttributes: new { @class = "form-control col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"input-group col-md-12\">\r\n                        ");
#nullable restore
#line 30 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.LabelFor(m => m.ProductDescription, htmlAttributes: new { @class = "col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 31 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.TextBoxFor(m => m.ProductDescription, htmlAttributes: new { @class = " form-control col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                </div>\r\n                <div class=\"form-group m-y-1\">\r\n                    <div class=\"input-group col-md-12\">\r\n                        ");
#nullable restore
#line 38 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.LabelFor(m => m.ProductQuantity, htmlAttributes: new { @class = "col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        ");
#nullable restore
#line 40 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.TextBoxFor(m => m.ProductQuantity, htmlAttributes: new { @class = "form-control col-md-3" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.DropDownListFor(m => m.ProductUnit, Html.GetEnumSelectList(typeof(MeasurementUnit)), new { @class = "form-control col-md-3 select2-drop-active" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                </div>\r\n                <div class=\"form-group m-y-1\">\r\n                    <div class=\"input-group col-md-12\">\r\n                        ");
#nullable restore
#line 48 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.LabelFor(m => m.ProductPrice, htmlAttributes: new { @class = "col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 49 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.TextBoxFor(m => m.ProductPrice, htmlAttributes: new { @class = "form-control col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                </div>\r\n                <div class=\"form-group m-y-1\">\r\n                    <div class=\"input-group col-md-12\">\r\n                        ");
#nullable restore
#line 56 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.LabelFor(m => m.ProductStatus, htmlAttributes: new { @class = "col-md-6" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 57 "D:\SampleProjects\ShopBridge\Views\Home\ProductEditorPage.cshtml"
                   Write(Html.DropDownListFor(m => m.ProductStatus, Html.GetEnumSelectList(typeof(ProductStatus)), new { @class = "form-control col-md-6 select2-drop-active" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>
                <footer class=""form-group m-y-1 pull-right"">
                    <div class=""input-group col-md-12"">
                        <button class=""btn-primary"" onclick=""ValidateForm();"" type=""button"">Submit</button>
                    </div>
                </footer>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    $.mask.definitions['d'] = '[0-9.]';
    $.mask.definitions['e'] = '[0-9]';
    $(""#ProductQuantity"").mask(""9?eeeeee"");
    $(""#ProductPrice"").mask(""9?dddddddd"");
    function ValidateForm() {
        $(""#ProductInfoData_Name"").val($(""#ProductName"").val().trim());
        var form = $('#productEditor-form');
        $.validator.unobtrusive.parse(form);
        var validator = form.data('validator');
        validator.settings.ignore = """";
        if (form.valid()) {
            form.submit();
        }
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
