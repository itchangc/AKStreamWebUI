#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a752c05683773a56c1b9be9f4293b4d5ca2436c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_Position_PositionForm), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/Position/PositionForm.cshtml")]
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
#line 3 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Enum.OrganizationManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a752c05683773a56c1b9be9f4293b4d5ca2436c", @"/Areas/OrganizationManage/Views/Position/PositionForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_OrganizationManage_Views_Position_PositionForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a752c05683773a56c1b9be9f4293b4d5ca2436c5509", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">职位名称<font class=""red""> *</font></label>
            <div class=""col-sm-8"">
                <input id=""positionName"" col=""PositionName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">显示顺序</label>
            <div class=""col-sm-8"">
                <input id=""positionSort"" col=""PositionSort"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">状态</label>
            <div id=""positionStatus"" col=""PositionStatus"" class=""col-sm-8""></div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-3 control-label"">备注</label>
            <div class=""col-sm-8"">
                <textarea id=""remark"" col=""Remark"" class=""form-control""></textarea>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        $(\"#positionStatus\").ysRadioBox({\r\n            data: ys.getJson(");
#nullable restore
#line 36 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
                        Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
        });

        getForm();

        $(""#form"").validate({
            rules: {
                positionName: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 51 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/Position/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var result = obj.Data;
                        $(""#form"").setWebControls(result);
                    }
                }
            });
        }
        else {
            ys.ajax({
                url: '");
#nullable restore
#line 63 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/Position/GetMaxSortJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""get"",
                success: function (obj) {
                    if (obj.Tag == 1) {
                        var defaultData = {};
                        defaultData.PositionSort = obj.Data;
                        defaultData.PositionStatus = """);
#nullable restore
#line 69 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
                                                 Write(StatusEnum.Yes.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
                        $(""#form"").setWebControls(defaultData);
                    }
                }
            });
        }
    }

    function saveForm(index) {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls({ Id: id });
            ys.ajax({
                url: '");
#nullable restore
#line 81 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\Position\PositionForm.cshtml"
                 Write(Url.Content("~/OrganizationManage/Position/SaveFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }
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
