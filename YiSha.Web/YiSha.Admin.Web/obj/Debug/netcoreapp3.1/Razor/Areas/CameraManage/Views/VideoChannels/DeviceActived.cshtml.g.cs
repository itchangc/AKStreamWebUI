#pragma checksum "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbbe4f8bd1f650af9121d5600c8eec5774e88979"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_CameraManage_Views_VideoChannels_DeviceActived), @"mvc.1.0.view", @"/Areas/CameraManage/Views/VideoChannels/DeviceActived.cshtml")]
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
#line 3 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Extension;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Util.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\_ViewImports.cshtml"
using YiSha.Web.Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbbe4f8bd1f650af9121d5600c8eec5774e88979", @"/Areas/CameraManage/Views/VideoChannels/DeviceActived.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b622e924f35698514110c8d85c04ddd5a27d39", @"/Areas/CameraManage/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_CameraManage_Views_VideoChannels_DeviceActived : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
  
    Layout = "~/Views/Shared/_FormWhite.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"wrapper animated fadeInRight\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbe4f8bd1f650af9121d5600c8eec5774e889795248", async() => {
                WriteLiteral(@"
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">设备ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""mainId"" col=""MainId"" type=""text"" class=""form-control"" disabled />
            </div>
            <label class=""col-sm-2 control-label "">通道名称<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""channelName"" col=""ChannelName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">部门代码</label>
            <div class=""col-sm-4"">
                <input id=""departmentId"" col=""DepartmentId"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">部门名称</label>
            <div class=""col-sm-4"">
                <input id=""departmentName"" col=""DepartmentName"" type=""text"" class=""form-control"" />
            </div>
        </div");
                WriteLiteral(@">
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">上级部门代码</label>
            <div class=""col-sm-4"">
                <input id=""pDepartmentId"" col=""PDepartmentId"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">上级部门名称</label>
            <div class=""col-sm-4"">
                <input id=""pDepartmentName"" col=""PDepartmentName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">拉取非rtp设备的流<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""methodByGetStream"" col=""MethodByGetStream""></div>
            </div>
            <label class=""col-sm-2 control-label "">自动启用录制计划<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""autoRecord"" col=""AutoRecord""></div>
            </div>
        </div>
        <div class=""form-grou");
                WriteLiteral(@"p"">
            <label class=""col-sm-2 control-label "">IpV4地址<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""ipV4Address"" col=""IpV4Address"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">IpV6地址<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""ipV6Address"" col=""IpV6Address"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">Channel ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""channelId"" col=""ChannelId"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">Device ID<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""deviceId"" col=""DeviceId"" type=""text"" class=""form-control"" />
            ");
                WriteLiteral(@"</div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">Vhost<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""vhost"" col=""Vhost"" type=""text"" class=""form-control"" />
            </div>
            <label class=""col-sm-2 control-label "">App<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <input id=""app"" col=""App"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">设备的流类型<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""deviceStreamType"" col=""DeviceStreamType""></div>
            </div>
            <label class=""col-sm-2 control-label "">云台控制<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""hasPtz"" col=""HasPtz""></div>
            </div>
        </div>
        <div cla");
                WriteLiteral(@"ss=""form-group"">
            <label class=""col-sm-2 control-label "">设备的网络类型<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""deviceNetworkType"" col=""DeviceNetworkType""></div>
            </div>
            <label class=""col-sm-2 control-label "">设备类型<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""videoDeviceType"" col=""VideoDeviceType""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">自动推拉流<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""autoVideo"" col=""AutoVideo""></div>
            </div>
            <label class=""col-sm-2 control-label "">录制计划模板名称</label>
            <div class=""col-sm-4"">
                <input id=""recordPlanName"" col=""RecordPlanName"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class");
                WriteLiteral(@"=""col-sm-2 control-label "">流媒体服务<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""mediaServerId"" col=""MediaServerId""></div>
            </div>
            <label class=""col-sm-2 control-label "">视频流源地址</label>
            <div class=""col-sm-4"">
                <input id=""videoSrcUrl"" col=""VideoSrcUrl"" type=""text"" class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">启用TCP推流<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""rtpWithTcp"" col=""RtpWithTcp""></div>
            </div>
            <label class=""col-sm-2 control-label "">使用默认端口<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""defaultRtpPort"" col=""DefaultRtpPort""></div>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-sm-2 control-label "">无人自动断流<font class=""red""> *</f");
                WriteLiteral(@"ont></label>
            <div class=""col-sm-4"">
                <div id=""noPlayerBreak"" col=""NoPlayerBreak""></div>
            </div>
            <label class=""col-sm-2 control-label "">是否启用<font class=""red""> *</font></label>
            <div class=""col-sm-4"">
                <div id=""enabled"" col=""Enabled""></div>
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
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    var id = ys.request(\"id\");\r\n    $(function () {\r\n        $(\"#autoRecord\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 143 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#hasPtz\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 144 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                              Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#autoVideo\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 145 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                                 Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#rtpWithTcp\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 146 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                                  Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#defaultRtpPort\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 147 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                                      Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#noPlayerBreak\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 148 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                                     Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(") });\r\n        $(\"#enabled\").ysRadioBox({ data: ys.getJson(");
#nullable restore
#line 149 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                                               Write(Html.Raw(typeof(StatusEnum).EnumToDictionaryString()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@") });

        $(""#videoDeviceType"").ysComboBox({
            data: top.getDataDict(""VideoDeviceType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });
        $(""#deviceStreamType"").ysComboBox({
            data: top.getDataDict(""DeviceStreamType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });
        $(""#deviceNetworkType"").ysComboBox({
            data: top.getDataDict(""DeviceNetworkType""),
            key: ""DictValue"",
            value: ""DictKey"",
            class: ""form-control""
        });
        $(""#videoDeviceType"").ysComboBox({
            data: top.getDataDict(""VideoDeviceType""),
            key: ""DictKey"",
            value: ""DictValue"",
            class: ""form-control""
        });
        $(""#methodByGetStream"").ysComboBox({
            data: top.getDataDict(""MethodByGetStream""),
            key: ""DictKey"",
            value: ""DictValue"",
        ");
            WriteLiteral("    class: \"form-control\"\r\n        });\r\n\r\n\r\n        $(\"#mediaServerId\").ysComboBox({\r\n            url: \'");
#nullable restore
#line 184 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
             Write(Url.Content("~/CameraManage/VideoChannels/GetMediaList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            key: ""mediaServerId"",
            value: ""mediaServerId"",
            class: ""form-control""
        });

        getForm();

        $('#form').validate({
            rules: {
                mainId: { required: true }
            }
        });
    });

    function getForm() {
        if (id > 0) {
            ys.ajax({
                url: '");
#nullable restore
#line 202 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                 Write(Url.Content("~/CameraManage/VideoChannels/GetFormJson"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '?id=' + id,
                type: 'get',
                success: function (obj) {
                    if (obj.Tag == 1) {
                        obj.Data.AutoRecord = obj.Data.AutoRecord == true ? 1 : 0;
                        obj.Data.HasPtz = obj.Data.HasPtz == true ? 1 : 0;
                        obj.Data.AutoVideo = obj.Data.AutoVideo == true ? 1 : 0;
                        obj.Data.RtpWithTcp = obj.Data.RtpWithTcp == true ? 1 : 0;
                        obj.Data.DefaultRtpPort = obj.Data.DefaultRtpPort == true ? 1 : 0;
                        obj.Data.NoPlayerBreak = obj.Data.NoPlayerBreak == true ? 1 : 0;
                        obj.Data.Enabled = obj.Data.Enabled == true ? 1 : 0;
                        $('#form').setWebControls(obj.Data);
                    }
                }
            });
        }
        else {
            var defaultData = {};
            $('#form').setWebControls(defaultData);
        }
    }

    function saveForm(index) {
        if ($('#fo");
            WriteLiteral("rm\').validate().form()) {\r\n            var postData = $(\'#form\').getWebControls({ Id: id });\r\n            ys.ajax({\r\n                url: \'");
#nullable restore
#line 228 "D:\TestCode\vue\AKStreamWebUI\YiSha.Web\YiSha.Admin.Web\Areas\CameraManage\Views\VideoChannels\DeviceActived.cshtml"
                 Write(Url.Content("~/CameraManage/VideoChannels/ActiveCamera"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                type: 'post',
                data: postData,
                success: function (obj) {
                    if (!!obj.mediaServerId) {
                        ys.msgSuccess(""设备激活成功"");
                        parent.searchGrid();
                        parent.layer.close(index);
                    }
                    else {
                        ys.msgError(""设备激活失败"");
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
