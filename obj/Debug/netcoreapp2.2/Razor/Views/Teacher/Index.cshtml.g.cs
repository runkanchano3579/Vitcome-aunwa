#pragma checksum "C:\Users\ok\Desktop\Vitcome-aunwa\Views\Teacher\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5386dc0481ca50ee5305cedb061f4fa5d9919012"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Index), @"mvc.1.0.view", @"/Views/Teacher/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Index.cshtml", typeof(AspNetCore.Views_Teacher_Index))]
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
#line 1 "C:\Users\ok\Desktop\Vitcome-aunwa\Views\_ViewImports.cshtml"
using netcore;

#line default
#line hidden
#line 2 "C:\Users\ok\Desktop\Vitcome-aunwa\Views\_ViewImports.cshtml"
using netcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5386dc0481ca50ee5305cedb061f4fa5d9919012", @"/Views/Teacher/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42f8c1e7f84b2085c62db58c14ae0e4f8b26c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Techer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(21, 771, true);
            WriteLiteral(@"<script>
    function checksent() {
        swal({
            title: ""คุณแน่ใจว่าจะส่งแบบเสนอหัวข้อนี้?"",
            text: ""กรุณาเช็คข้อมูลให้ถูกต้องก่อนส่งพื่อป้องกันการเกิดปัญหาในภายหลัง!"",
            icon: ""warning"",
            buttons: true,
            dangerMode: true,
        })
            .then((willDelete) => {
                if (willDelete) {
                    swal(""คุณได้ทำการส่งฟอร์มCS1เรียบร้อยแล้วครับ!"", {
                        icon: ""success"",
                    });
                    window.location.assign(""home/index"")


                } else {
                    swal(""ยกเลิกการส่งสำเร็จ!"");
                }
            });
    }
</script>
<h3 style=""text-align:center;"">เลือก อ.ที่ปรึกษา </h3>
<p>ลำดับที่ ");
            EndContext();
            BeginContext(793, 10, false);
#line 26 "C:\Users\ok\Desktop\Vitcome-aunwa\Views\Teacher\Index.cshtml"
       Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(803, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(813, 25, false);
#line 27 "C:\Users\ok\Desktop\Vitcome-aunwa\Views\Teacher\Index.cshtml"
Write(Model[@ViewBag.Id-1].Name);

#line default
#line hidden
            EndContext();
            BeginContext(838, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(846, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5386dc0481ca50ee5305cedb061f4fa5d99190125636", async() => {
                BeginContext(900, 255, true);
                WriteLiteral("\r\n    <div class=\"form-group card-body card\">\r\n        <span>ชื่อเรื่องวิจัย</span><input class=\"form-control\" type=\"text\" name=\"idstudent\" value=\"\">\r\n        <span>แนบฟอร์ม CS1 </span>\r\n        <input class=\"form-control\" type=\"file\" name=\"file\" id=\"\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1162, 129, true);
            WriteLiteral("\r\n\r\n    </div>\r\n<button type=\"button\" class=\"btn btn-info btn-lg btn-block\" onclick=\"checksent()\">ส่งเอกสารยื่นหัวข้อCS1</button>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Techer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
