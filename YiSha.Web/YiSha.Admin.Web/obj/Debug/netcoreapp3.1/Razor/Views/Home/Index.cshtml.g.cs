#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f723530224ac8d125f0ad4232201028884927c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Entity.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Enum.SystemManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Admin.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f723530224ac8d125f0ad4232201028884927c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10467f6850395725752005e8267616b06b0df080", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
  
    ViewBag.Title = "AKStreamWebUI";
    Layout = "~/Views/Shared/_Layout.cshtml";

    OperatorInfo operatorInfo = ViewBag.OperatorInfo;
    String portrait = operatorInfo.Portrait;
    if (portrait == null || string.IsNullOrEmpty(portrait))
    {
        portrait = Url.Content("~/image/portrait.png");
    }
    else
    {
        portrait = GlobalContext.SystemConfig.ApiSite + portrait;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
Write(BundlerHelper.Render(HostingEnvironment.ContentRootPath, Url.Content("~/yisha/js/yisha-data.min.js")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div id=""wrapper"">
    <!--左侧导航开始-->
    <nav class=""navbar-default navbar-static-side"" role=""navigation"">
        <div class=""nav-close"">
            <i class=""fa fa-times-circle""></i>
        </div>
        <div class=""sidebar-collapse"">
            <ul class=""nav"" id=""side-menu"">
                <li class=""logo"">AKStreamWebUI</li>
                <li class=""nav-header"">
                    <div class=""dropdown profile-element clear"">
                        <div class=""image-left"">
                            <img alt=""image""");
            BeginWriteAttribute("src", " src=\'", 1147, "\'", 1162, 1);
#nullable restore
#line 31 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1153, portrait, 1153, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle\" height=\"50\" width=\"50\" />\r\n                        </div>\r\n                        <div class=\"image-right\">\r\n                            <span class=\"block m-t-xs\">");
#nullable restore
#line 34 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                  Write(operatorInfo.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"text-xs block\">");
#nullable restore
#line 35 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                   Write(operatorInfo.DepartmentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 39 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                  
                    List<MenuEntity> menuList = ViewBag.MenuList;
                    foreach (MenuEntity menu in menuList.Where(p => p.ParentId == 0).OrderBy(p => p.MenuSort))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-type=\"menu\">\r\n");
#nullable restore
#line 44 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                              
                                if (HttpHelper.IsUrl(menu.MenuUrl))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"menuItem\"");
            BeginWriteAttribute("href", " href=\"", 2015, "\"", 2035, 1);
#nullable restore
#line 47 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2022, menu.MenuUrl, 2022, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 2081, "\"", 2103, 1);
#nullable restore
#line 48 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2089, menu.MenuIcon, 2089, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <span class=\"nav-label\">");
#nullable restore
#line 49 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                           Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </a>\r\n");
#nullable restore
#line 51 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"#\">\r\n                                        <i");
            BeginWriteAttribute("class", " class=\"", 2440, "\"", 2462, 1);
#nullable restore
#line 55 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2448, menu.MenuIcon, 2448, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                        <span class=\"nav-label\">");
#nullable restore
#line 56 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                           Write(menu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"fa arrow\"></span>\r\n                                    </a>\r\n");
#nullable restore
#line 59 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <ul class=\"nav nav-second-level collapse\" data-type=\"menu\">\r\n");
#nullable restore
#line 62 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                 foreach (MenuEntity secondMenu in menuList.Where(p => p.ParentId == menu.Id).OrderBy(p => p.MenuSort))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li data-type=\"menu\">\r\n");
#nullable restore
#line 65 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                          
                                            if (menuList.Where(p => p.ParentId == secondMenu.Id && p.MenuType != (int)MenuTypeEnum.Button).Count() == 0)
                                            {
                                                if (HttpHelper.IsUrl(secondMenu.MenuUrl))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a class=\"menuItem\"");
            BeginWriteAttribute("href", " href=\'", 3515, "\'", 3541, 1);
#nullable restore
#line 70 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3522, secondMenu.MenuUrl, 3522, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                              Write(secondMenu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 71 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a class=\"menuItem\" href=\"#\" data-url=\'");
#nullable restore
#line 74 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                      Write(Url.Content("~/" + secondMenu.MenuUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>");
#nullable restore
#line 74 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                                                               Write(secondMenu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 75 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                }
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a href=\"#\">");
#nullable restore
#line 79 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                       Write(secondMenu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"fa arrow\"></span></a>\r\n                                                <ul class=\"nav nav-third-level\" data-type=\"menu\">\r\n");
#nullable restore
#line 81 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                     foreach (MenuEntity thirdMenu in menuList.Where(p => p.ParentId == secondMenu.Id).OrderBy(p => p.MenuSort))
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li data-type=\"menu\">\r\n                                                            <a class=\"menuItem\" href=\"#\" data-url=\'");
#nullable restore
#line 84 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                              Write(Url.Content("~/" + thirdMenu.MenuUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'>");
#nullable restore
#line 84 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                                                                      Write(thirdMenu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </li>\r\n");
#nullable restore
#line 86 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 88 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 91 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 94 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </ul>
        </div>
    </nav>
    <!--左侧导航结束-->
    <!--右侧部分开始-->
    <div id=""page-wrapper"" class=""gray-bg dashbard-1"">
        <div class=""row"">
            <nav class=""navbar navbar-static-top"" role=""navigation"" style=""margin-bottom: 0"">
                <a class=""navbar-minimalize minimalize-styl-2"" href=""#"" title=""收起菜单"">
                    <i class=""fa fa-bars""></i>
                </a>
                <ul class=""nav navbar-top-links navbar-right welcome-message"">
                    <li><a id=""fullScreen""><i class=""fa fa-arrows-alt""></i>全屏</a></li>
                    <li class=""dropdown user-menu"">
                        <a href=""javascript:void(0)"" class=""dropdown-toggle"" data-hover=""dropdown"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 5976, "\"", 5991, 1);
#nullable restore
#line 111 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5982, portrait, 5982, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"user-image\">\r\n                            <span class=\"hidden-xs\">");
#nullable restore
#line 112 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                               Write(operatorInfo.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </a>\r\n                        <ul class=\"dropdown-menu\">\r\n                            <li class=\"mt5\">\r\n                                <a class=\"menuItem\" href=\"#\" data-url=\'");
#nullable restore
#line 116 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                  Write(Url.Content("~/OrganizationManage/User/UserDetail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?id=");
#nullable restore
#line 116 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                                                          Write(operatorInfo.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'>
                                    <i class=""fa fa-user""></i> 个人中心
                                </a>
                            </li>
                            <li>
                                <a onclick=""showChangePasswordForm()"">
                                    <i class=""fa fa-key""></i> 修改密码
                                </a>
                            </li>
                            <li>
                                <a onclick=""showSwitchSkinForm()"">
                                    <i class=""fa fa-dashboard""></i> 切换主题
                                </a>
                            </li>
                            <li class=""divider""></li>
                            <li>
                                <a");
            BeginWriteAttribute("href", " href=\"", 7137, "\"", 7175, 1);
#nullable restore
#line 132 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 7144, Url.Content("~/Home/LoginOff"), 7144, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <i class=""fa fa-sign-out""></i> 退出登录
                                </a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </div>
        <div class=""row content-tabs"">
            <button class=""roll-nav roll-left tabLeft"">
                <i class=""fa fa-backward""></i>
            </button>
            <nav class=""page-tabs menuTabs"">
                <div class=""page-tabs-content"">
                    <a href=""javascript:;"" class=""active menuTab"" data-id=""/system/main"">首页</a>
                </div>
            </nav>
            <button class=""roll-nav roll-right tabRight"">
                <i class=""fa fa-forward""></i>
            </button>
            <div class=""btn-group roll-nav roll-right"">
                <button class=""dropdown J_tabClose"" data-toggle=""dropdown"">
                    页签操作<span class=""caret""></span>
                </button>
           ");
            WriteLiteral(@"     <ul role=""menu"" class=""dropdown-menu dropdown-menu-right"">
                    <li><a class=""tabCloseCurrent"" href=""#"">关闭当前</a></li>
                    <li><a class=""tabCloseOther"" href=""#"">关闭其他</a></li>
                    <li><a class=""tabCloseAll"" href=""#"">全部关闭</a></li>
                </ul>
            </div>
            <a href=""#"" class=""roll-nav roll-right tabReload""><i class=""fa fa-refresh""></i> 刷新</a>
        </div>
        <div class=""row mainContent"" id=""content-main"">
            <iframe class=""YiSha_iframe"" name=""iframe0"" width=""100%"" height=""100%"" data-id=""/system/main""");
            BeginWriteAttribute("src", " src=\"", 8805, "\"", 8858, 1);
#nullable restore
#line 166 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 8811, Url.Content("~/ToolManage/Server/ServerIndex"), 8811, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0"" seamless></iframe>
        </div>
    </div>
    <!--右侧部分结束-->
</div>

<script type=""text/javascript"">
    if (!ys.isNullOrEmpty($.cookie('Skin'))) {
        var skin = decodeURIComponent($.cookie('Skin'));
        $(""body"").addClass(skin.split('|')[0]);
        $(""body"").addClass(skin.split('|')[1]);
    } else {
        var sideTheme = ""theme-dark"";
        var skinName = ""skin-blue"";
        $(""body"").addClass(sideTheme);
        $(""body"").addClass(skinName);
    }

    function showChangePasswordForm() {
        ys.openDialog({
            title: ""修改密码"",
            content: '");
#nullable restore
#line 187 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                 Write(Url.Content("~/OrganizationManage/User/ChangePassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\' + \'?id=");
#nullable restore
#line 187 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                                                                                  Write(operatorInfo.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            height: ""500px"",
            callback: function (index, layero) {
                var iframeWin = window[layero.find('iframe')[0]['name']];
                iframeWin.saveForm(index);
            }
        });
    }

    function showSwitchSkinForm() {
        ys.openDialog({
            title: ""切换主题"",
            content: '");
#nullable restore
#line 199 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Views\Home\Index.cshtml"
                 Write(Url.Content("~/Home/Skin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            width: \'530px\',\r\n            height: \'390px\',\r\n            btn: null,\r\n            maxmin: false\r\n        });\r\n    }\r\n</script>\r\n");
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
