#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "330e7feb07c0e94e616d9d9f6f6fe0930d0eaa08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OrganizationManage_Views_User_UserImport), @"mvc.1.0.view", @"/Areas/OrganizationManage/Views/User/UserImport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330e7feb07c0e94e616d9d9f6f6fe0930d0eaa08", @"/Areas/OrganizationManage/Views/User/UserImport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45dbd51f3d139278b58e1807e343bf3fa8e8229", @"/Areas/OrganizationManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_OrganizationManage_Views_User_UserImport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("header", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/css/fileinput.min.css")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 8 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/fileinput/5.0.3/js/fileinput.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "330e7feb07c0e94e616d9d9f6f6fe0930d0eaa086344", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">选择文件</label>
            <div class=""col-sm-10"">
                <input id=""importFile"" type=""file"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label ""></label>
            <div class=""col-sm-4"">
                <div id=""isOverride"" col=""IsOverride""></div>
            </div>
            <div class=""control-label"" style=""text-align:left"">
                <a");
                BeginWriteAttribute("href", " href=\'", 1016, "\'", 1061, 1);
#nullable restore
#line 25 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
WriteAttributeValue("", 1023, Url.Content("~/template/导入用户模板.xlsx"), 1023, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-default btn-xs""><i class=""fa fa-file-excel-o""></i> 下载模板</a>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label ""></label>
            <div class=""col-sm-10 text-danger"">
                提示：仅允许导入“xls”或“xlsx”格式文件！
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
            WriteLiteral(@"
</div>

<script type=""text/javascript"">
    var filePath = undefined;
    $(document).ready(function () {
        $(""#isOverride"").ysCheckBox({
            data: [{ Key: '1', Value: '是否更新已经存在的用户数据' }]
        });

        $(""#importFile"").fileinput({
            language: 'zh',
            'uploadUrl': '");
#nullable restore
#line 46 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
                     Write(Url.Content("~/File/UploadFile"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?fileModule=");
#nullable restore
#line 46 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
                                                                       Write(UploadFileType.Import.ParseToInt());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            showPreview: false,
            allowedFileExtensions: ['xls', 'xlsx']
        }).on(""fileuploaded"", function (event, data) {
            var obj = data.response;
            if (obj.Tag == 1) {
                filePath = obj.Data;
            }
            else {
                filePath = '';
            }
        });
    });

    function saveForm(index) {
        if (!filePath) {
            ys.alertError('文件未上传或者上传失败');
            return;
        }

        var postData =$(""#form"").getWebControls();
        postData.FilePath = filePath;
        ys.ajax({
            url: '");
#nullable restore
#line 69 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\OrganizationManage\Views\User\UserImport.cshtml"
             Write(Url.Content("~/OrganizationManage/User/ImportUserJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            type: ""post"",
            data: postData,
            success: function (obj) {
                if (obj.Tag == 1) {
                    ys.msgSuccess('导入成功');
                    parent.searchGrid();
                    parent.layer.close(index);
                }
                else {
                    ys.msgError(obj.Message);
                }
            }
        });
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; } = default!;
        #nullable disable
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
