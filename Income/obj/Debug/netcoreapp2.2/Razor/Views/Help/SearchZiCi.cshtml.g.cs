#pragma checksum "/home/yuluo/WorkSpace/Rider/income/Income/Views/Help/SearchZiCi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cea1f44a24f58c3037f8b52914f2c478fb1dcd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Help_SearchZiCi), @"mvc.1.0.view", @"/Views/Help/SearchZiCi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Help/SearchZiCi.cshtml", typeof(AspNetCore.Views_Help_SearchZiCi))]
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
#line 1 "/home/yuluo/WorkSpace/Rider/income/Income/Views/_ViewImports.cshtml"
using Demo2;

#line default
#line hidden
#line 2 "/home/yuluo/WorkSpace/Rider/income/Income/Views/_ViewImports.cshtml"
using Demo2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cea1f44a24f58c3037f8b52914f2c478fb1dcd6", @"/Views/Help/SearchZiCi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e4fe301a35ef20f5ee89a163529b74b9f60331", @"/Views/_ViewImports.cshtml")]
    public class Views_Help_SearchZiCi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ValidateJS.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/yuluo/WorkSpace/Rider/income/Income/Views/Help/SearchZiCi.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(39, 387, true);
            WriteLiteral(@"
<!DOCTYPE html>

<html>
<!-- jquery -->
<script src=""https://cdn.h5ds.com/lib/plugins/jquery.min.js""></script>

<!-- vue -->
<script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>

<!-- element样式 -->
<link rel=""stylesheet"" href=""https://unpkg.com/element-ui/lib/theme-chalk/index.css"">
<!-- element组件库 -->
<script src=""https://unpkg.com/element-ui/lib/index.js""></script>
");
            EndContext();
            BeginContext(426, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cea1f44a24f58c3037f8b52914f2c478fb1dcd64383", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(468, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(469, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cea1f44a24f58c3037f8b52914f2c478fb1dcd65540", async() => {
                BeginContext(475, 26, true);
                WriteLiteral("\n    <title>title</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(508, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(509, 884, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cea1f44a24f58c3037f8b52914f2c478fb1dcd66724", async() => {
                BeginContext(515, 871, true);
                WriteLiteral(@"
<div id=""app"">
  <div>
    包含**的词语:
    <el-input label=""包含词语："" v-model=""searchCiYuName"" placeholder=""请输入内容"" style=""width:200px;""></el-input>
    
    <el-button type=""primary"" v-on:click=""searchCiYu"">搜索</el-button>
    
    <div>数量:{{listNumCiYu}}</div>
  </div>
  <div style=""padding-top: 20px"">
    <el-input
      type=""textarea""
      :rows=""10""
      placeholder=""""
      v-model=""textAreaCiYu"">
    </el-input>
  </div>
  <div style=""margin-top: 50px"">
    包含**的字:
    <el-input label=""包含字："" v-model=""searchZiName"" placeholder=""请输入内容"" style=""width:200px;""></el-input>
    
    <el-button type=""primary"" v-on:click=""searchZi"">搜索</el-button>
    <div>数量:{{listNumZi}}</div>
  </div>
  <div style=""padding-top: 20px"">
      <el-input
        type=""textarea""
        :rows=""10""
        placeholder=""""
        v-model=""textAreaZi"">
      </el-input>
    </div>
</div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1393, 1778, true);
            WriteLiteral(@"
<script>
  let app = new Vue({
    el: '#app', //DOM中id为app的HTML div标签
    data: {
      searchCiYuName: '',
      searchZiName:'',
      textAreaCiYu: '',
      textAreaZi: '',
      listNumCiYu:0,
      listNumZi:0,
      tempArray:[],
      data:{},
    },
    methods:{
      searchCiYu(){
        let that = this;
        debugger;
        let name = that.searchCiYuName;
        if(!isEmpty(name.trim())) {
          $.get(""/Help/GetCiYu"", {
            md: name,
          },function (resp) {
            let type = resp.code == 1? 'success' : 'error';
            that.$message({
                message: resp.message,
                type: type,
                center: true,
            });
            that.textAreaCiYu = resp.data.result;
            that.listNumCiYu = resp.data.listNum;
          }, 'json');
        }
      },
      searchZi(){
        let that = this;
        let name = that.searchZiName;
        if(!isEmpty(name.trim())) {
          $.get(""/Help/GetZi"", {
            md: name,
         ");
            WriteLiteral(@" },function (resp) {
            let type = resp.code == 1? 'success' : 'error';
            that.$message({
                message: resp.message,
                type: type,
                center: true,
            });
            that.textAreaZi = resp.data.result;
            that.listNumZi = resp.data.listNum;
          }, 'json');
        }
      },
    },
    beforeCreate: function () {

    },
    created: function () {
      // this.getRecipeList();
      // this.getRecipeTypeList();
    },
    beforeMount: function () {

    },
    mounted: function () {
    },
    beforeUpdate: function () {

    },
    updated: function () {

    },
    beforeDestroy: function () {

    },
    destroyed: function () {

    }
  });
</script>
</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
