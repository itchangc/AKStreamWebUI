#pragma checksum "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1b3a12c7f37f2b34fdb2c7e6064dfcf0e70edf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Entity.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Admin.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1b3a12c7f37f2b34fdb2c7e6064dfcf0e70edf", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10467f6850395725752005e8267616b06b0df080", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
  
    ViewBag.Title = "众达流媒体管理系统 - 登录";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("header", async() => {
                WriteLiteral("\r\n    <link");
                BeginWriteAttribute("href", " href=\'", 197, "\'", 241, 1);
#nullable restore
#line 7 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 204, Url.Content("~/yisha/css/login.css"), 204, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <script>\r\n        if (window.top !== window.self) { window.top.location = window.location };\r\n    </script>\r\n    ");
#nullable restore
#line 11 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/lib/jquery.validation/1.14.0/jquery.validate.min.js")));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div class=\"login-panel\">\r\n    <div class=\"row section\">\r\n        <div class=\"col-sm-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1b3a12c7f37f2b34fdb2c7e6064dfcf0e70edf5844", async() => {
                WriteLiteral("\r\n                <h4 class=\"no-margin\">登录：</h4>\r\n                <p class=\"m-t-md\">众达流媒体管理系统</p>\r\n");
                WriteLiteral("                <input id=\"userName\" name=\"userName\" class=\"form-control uname\" col=\"UserName\" type=\"text\" placeholder=\"用户名\"");
                BeginWriteAttribute("value", " value=\"", 938, "\"", 963, 1);
#nullable restore
#line 20 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 946, ViewBag.UserName, 946, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input id=\"password\" name=\"password\" class=\"form-control pword m-b\" col=\"Password\" type=\"password\" placeholder=\"密码\"");
                BeginWriteAttribute("value", " value=\"", 1100, "\"", 1125, 1);
#nullable restore
#line 21 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 1108, ViewBag.Password, 1108, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""row"">
                    <div class=""col-xs-6"">
                        <input id=""captchaCode"" name=""captchaCode"" type=""text"" col=""CaptchaCode"" class=""form-control code"" placeholder=""验证码"" maxlength=""3"">
                    </div>
                    <div class=""col-xs-6"">
                        <a href=""javascript:void(0);"" title=""点击更换验证码"">
                            <img id=""imgCaptchaCode""");
                BeginWriteAttribute("src", " src=\'", 1563, "\'", 1607, 1);
#nullable restore
#line 28 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
WriteAttributeValue("", 1569, Url.Content("~/Home/GetCaptchaImage"), 1569, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" height=""34"" />
                        </a>
                    </div>
                </div>
                <div class=""checkbox-custom"">
                    <input id=""rememberMe"" name=""rememberMe"" type=""checkbox""> <label for=""rememberMe"">记住我</label>
                </div>
                <button class=""btn btn-success btn-block"" onclick=""loginForm(); return false;"">登录</button>
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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"login-footer\">\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n<script type=\"text/javascript\">\r\n    $(function () {\r\n        if ($.cookie(\'RememberMe\') == 1) {\r\n            $(\"#rememberMe\").prop(\"checked\", true);\r\n            if (\"");
#nullable restore
#line 50 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
            Write(GlobalContext.SystemConfig.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" == ""Cookie"") {
                if (!ys.isNullOrEmpty($.cookie('UserToken'))) {
                    redirectToIndex();
                }
            }
            else {
                $.removeCookie(""UserToken"", { path: '/' });
            }
        }
        $(""#rememberMe"").click(function () {
            if ($(this).prop(""checked"")) {
                $.cookie('RememberMe', 1, { expires: 30, path: '/' });
            }
        });

        $(""#imgCaptchaCode"").click(function () {
            $(this).attr(""src"", '");
#nullable restore
#line 66 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
                            Write(Url.Content("~/Home/GetCaptchaImage"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?t=' + new Date().getTime());
        });

        $(""#form"").validate({
            rules: {
                userName: { required: true },
                password: { required: true }
            }
        });

        $.validator.setDefaults({
            submitHandler: function () {
                loginForm();
            }
        });
    });

    function loginForm() {
        if ($(""#form"").validate().form()) {
            var postData = $(""#form"").getWebControls();
            ys.ajax({
                url: '");
#nullable restore
#line 87 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
                 Write(Url.Content("~/Home/LoginJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: ""post"",
                data: postData,
                success: function (obj) {
                    if (obj.Tag == 1) {
                        ys.msgSuccess(obj.Message);
                        redirectToIndex();
                    }
                    else {
                        ys.msgError(obj.Message);
                    }
                }
            });
        }
    }

    function redirectToIndex() {
        location.href = '");
#nullable restore
#line 104 "E:\源码\YiShaAdmin\YiShaAdmin\YiSha.Web\YiSha.Admin.Web\Views\Home\Login.cshtml"
                    Write(Url.Content("~/Home/Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Hosting.IWebHostEnvironment HostingEnvironment { get; private set; }
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