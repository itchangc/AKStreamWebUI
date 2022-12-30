#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52ed44c381781f41bbace4683170c9825eba9748"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Table_Footer), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Table/Footer.cshtml")]
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
#line 3 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ed44c381781f41bbace4683170c9825eba9748", @"/Areas/DemoManage/Views/Table/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_DemoManage_Views_Table_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Footer.cshtml"
  
    Layout = "~/Views/Shared/_Index.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-div"">
    <div class=""row"">
        <div class=""col-sm-12 select-table table-striped"">
            <table id=""gridTable"" data-mobile-responsive=""true""></table>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        initGrid();
    });

    function initGrid() {
        var queryUrl = '");
#nullable restore
#line 19 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Table\Footer.cshtml"
                   Write(Url.Content("~/DemoManage/Table/GetPageListJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
        $('#gridTable').ysTable({
            url: queryUrl,
            showFooter: true,
            columns: [
                { checkbox: true, visible: true },
                { field: 'Id', title: '用户编号' },
                { field: 'RealName', title: '用户姓名' },
                { field: 'Mobile', title: '手机' },
                { field: 'Email', title: '邮箱' },
                {
				    field : 'LoginCount',
				    title : '登录次数',
				    footerFormatter:function (value) {
				    	var sumBalance = 0;
				        for (var i in value) {
				        	sumBalance += parseFloat(value[i].LoginCount);
				        }
				        return ""总次数："" + sumBalance;
				    }
				},
                {
                    title: '操作',
                    align: 'center',
                    formatter: function (value, row, index) {
                        var actions = [];
                        actions.push('<a class=""btn btn-success btn-xs"" href=""#""><i class=""fa fa-edit""></i>编辑</a> ');
        ");
            WriteLiteral(@"                actions.push('<a class=""btn btn-danger btn-xs"" href=""#""><i class=""fa fa-remove""></i>删除</a>');
                        return actions.join('');
                    }
                }
            ],
            queryParams: function (params) {
                var pagination = $('#gridTable').ysTable('getPagination', params);
                var queryString = $('#searchDiv').getWebControls(pagination);
                return queryString;
            }
        });
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
