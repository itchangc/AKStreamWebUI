#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Datetime.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abfb5bb603292b5a11657041480eee8d5e423e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_DemoManage_Views_Form_Datetime), @"mvc.1.0.view", @"/Areas/DemoManage/Views/Form/Datetime.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abfb5bb603292b5a11657041480eee8d5e423e92", @"/Areas/DemoManage/Views/Form/Datetime.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/DemoManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_DemoManage_Views_Form_Datetime : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\DemoManage\Views\Form\Datetime.cshtml"
  
    Layout = "~/Views/Shared/_FormGray.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-sm-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>日期选择器 <small>https://github.com/sentsin/laydate</small></h5>
                </div>
                <div class=""ibox-content"">
                    <div class=""form-group"">
                        <label class=""font-noraml"">简单示例</label>
                        <div class=""input-group date"">
                            <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                            <input type=""text"" class=""form-control"" id=""laydate-demo-1"" placeholder=""yyyy-MM-dd"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">显示年月日</label>
                        <div class=""input-group date"">
                            <span class=""input-grou");
            WriteLiteral(@"p-addon""><i class=""fa fa-calendar""></i></span>
                            <input type=""text"" class=""form-control"" id=""laydate-demo-2"" placeholder=""yyyy-MM-dd"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">显示年月日时分秒</label>
                        <div class=""input-group date"">
                            <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                            <input type=""text"" class=""form-control"" id=""laydate-demo-3"" placeholder=""yyyy-MM-dd HH:mm:ss"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">单框范围选择</label>
                        <div class=""input-group date"">
                            <span class=""input-group-addon""><i class=""fa fa-calendar""></i></span>
                            <input type=""text"" class=""form-control"" id=""lay");
            WriteLiteral(@"date-demo-4"" placeholder=""yyyy-MM-dd - yyyy-MM-dd"">
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label class=""font-noraml"">日期范围选择</label>
                        <div class=""input-daterange input-group"">
                            <input type=""text"" class=""input-sm form-control"" id=""laydate-startTime"" placeholder=""yyyy-MM-dd"" />
                            <span class=""input-group-addon"">到</span>
                            <input type=""text"" class=""input-sm form-control"" id=""laydate-endTime"" placeholder=""yyyy-MM-dd"" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script type=""text/javascript"">
    $(function () {
        laydate.render({
            elem: '#laydate-demo-1'
        });

        laydate.render({
            elem: '#laydate-demo-2',
            type: 'date'
        });

        laydate.render({");
            WriteLiteral(@"
            elem: '#laydate-demo-3',
            type: 'datetime',
            trigger: 'click'
        });

        laydate.render({
            elem: '#laydate-demo-4',
            range: true
        });

        var startDate = laydate.render({
            elem: '#laydate-startTime',
            max: $('#laydate-endTime').val(),
            theme: 'molv',
            trigger: 'click',
            done: function (value, date) {
                // 结束时间大于开始时间
                if (value !== '') {
                    endDate.config.min.year = date.year;
                    endDate.config.min.month = date.month - 1;
                    endDate.config.min.date = date.date;
                } else {
                    endDate.config.min.year = '';
                    endDate.config.min.month = '';
                    endDate.config.min.date = '';
                }
            }
        });

        var endDate = laydate.render({
            elem: '#laydate-endTime',
            min");
            WriteLiteral(@": $('#laydate-startTime').val(),
            theme: 'molv',
            trigger: 'click',
            done: function (value, date) {
                // 开始时间小于结束时间
                if (value !== '') {
                    startDate.config.max.year = date.year;
                    startDate.config.max.month = date.month - 1;
                    startDate.config.max.date = date.date;
                } else {
                    startDate.config.max.year = '';
                    startDate.config.max.month = '';
                    startDate.config.max.date = '';
                }
            }
        });
    });
</script>");
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
