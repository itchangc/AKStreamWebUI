#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\Views\CodeGenerator\CodeGeneratorEditToolbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12d30abfeaeef2bc1bce4a75e0be9bcb8c5bdff5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ToolManage_Views_CodeGenerator_CodeGeneratorEditToolbar), @"mvc.1.0.view", @"/Areas/ToolManage/Views/CodeGenerator/CodeGeneratorEditToolbar.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 2 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d30abfeaeef2bc1bce4a75e0be9bcb8c5bdff5", @"/Areas/ToolManage/Views/CodeGenerator/CodeGeneratorEditToolbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6b14b0495a88e844c2fb3bae387fe9eca56f1d", @"/Areas/ToolManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_ToolManage_Views_CodeGenerator_CodeGeneratorEditToolbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal m"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\Views\CodeGenerator\CodeGeneratorEditToolbar.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d30abfeaeef2bc1bce4a75e0be9bcb8c5bdff55301", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">是否需要 新增</label>
            <div class=""col-sm-8"" id=""addStatus"" ref=""btnAdd""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">是否需要 修改</label>
            <div class=""col-sm-8"" id=""editStatus"" ref=""btnEdit""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">是否需要 删除</label>
            <div class=""col-sm-8"" id=""deleteStatus"" ref=""btnDelete""></div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    $(function () {

        var btnAdd = $(""#btnAdd"", parent.document);
        var btnEdit = $(""#btnEdit"", parent.document);
        var btnDelete = $(""#btnDelete"", parent.document);

        $(""#addStatus"").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 29 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\Views\CodeGenerator\CodeGeneratorEditToolbar.cshtml"
                                                 Write(Html.Raw(typeof(NeedEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#editStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 30 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\Views\CodeGenerator\CodeGeneratorEditToolbar.cshtml"
                                                  Write(Html.Raw(typeof(NeedEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#deleteStatus\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 31 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\ToolManage\Views\CodeGenerator\CodeGeneratorEditToolbar.cshtml"
                                                    Write(Html.Raw(typeof(NeedEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        $('input').on('ifChecked', function (event) {
            var ref = $(this).attr(""ref"");
            var val = $(this).val();
            if (val == 1) {
                $(""#"" + ref, parent.document).show();
            }
            else {
                $(""#"" + ref, parent.document).hide();
            }
        });

        // 设置默认值
        if (btnAdd.is(':hidden')) {
            $(""#addStatus"").ysRadioBox('setValue',0);
        }
        else {
            $(""#addStatus"").ysRadioBox('setValue',1);
        }

        if (btnEdit.is(':hidden')) {
            $(""#editStatus"").ysRadioBox('setValue',0);
        }
        else {
            $(""#editStatus"").ysRadioBox('setValue',1);
        }

        if (btnDelete.is(':hidden')) {
            $(""#deleteStatus"").ysRadioBox('setValue',0);
        }
        else {
            $(""#deleteStatus"").ysRadioBox('setValue',1);
        }

    });


</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
