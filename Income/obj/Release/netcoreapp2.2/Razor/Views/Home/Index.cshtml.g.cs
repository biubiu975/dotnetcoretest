#pragma checksum "/home/yuluo/WorkSpace/Rider/income/Income/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09c14c39819c53fd0db18fbdb7799442b65c974e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09c14c39819c53fd0db18fbdb7799442b65c974e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e4fe301a35ef20f5ee89a163529b74b9f60331", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow-y: hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 67, true);
            WriteLiteral("<!DOCTYPE html>\n<html xmlns:v-bind=\"http://www.w3.org/1999/xhtml\">\n");
            EndContext();
            BeginContext(67, 1010, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09c14c39819c53fd0db18fbdb7799442b65c974e4494", async() => {
                BeginContext(73, 118, true);
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
                EndContext();
                BeginContext(192, 17, false);
#line 6 "/home/yuluo/WorkSpace/Rider/income/Income/Views/Home/Index.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(209, 22, true);
                WriteLiteral(" - Income</title>\n    ");
                EndContext();
                BeginContext(231, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "09c14c39819c53fd0db18fbdb7799442b65c974e5338", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(278, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(449, 24, true);
                WriteLiteral("    \n    <!-- iview -->\n");
                EndContext();
                BeginContext(673, 26, true);
                WriteLiteral("    \n    <!-- element -->\n");
                EndContext();
                BeginContext(873, 197, true);
                WriteLiteral("    <!-- 引入样式 -->\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/element-ui/lib/theme-chalk/index.css\">\n    <!-- 引入组件库 -->\n    <script src=\"https://unpkg.com/element-ui/lib/index.js\"></script>\n");
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
            BeginContext(1077, 842, true);
            WriteLiteral(@"
<style scoped>
    .layout{
        border: 1px solid #d7dde4;
        background: #f5f7f9;
        position: relative;
        border-radius: 4px;
        overflow: hidden;
    }
    .layout-logo{
        width: 100px;
        height: 30px;
        background: #5b6270;
        border-radius: 3px;
        float: left;
        position: relative;
        top: 15px;
        left: 20px;
    }
    .layout-nav{
        width: 420px;
        margin: 0 auto;
        margin-right: 20px;
    }
    .layout-footer-center{
        text-align: center;
    }
    .el-header {
        background-color: #B3C0D1;
        color: #333;
        line-height: 60px;
      }
      
  .el-aside {
    color: #333;
  }
  
  .el-dropdown-link {
      cursor: pointer;
      color: #409EFF;
    }
    .el-icon-arrow-down {
      font-size: 12px;
    }
</style>
");
            EndContext();
            BeginContext(1919, 5370, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09c14c39819c53fd0db18fbdb7799442b65c974e8863", async() => {
                BeginContext(1952, 122, true);
                WriteLiteral("\n<div id=\"app\">\n    <div id=\"head\">\n        <el-menu :default-active=\"activeIndex\" class=\"el-menu-demo\" mode=\"horizontal\" ");
                EndContext();
                BeginContext(2075, 526, true);
                WriteLiteral(@"@select=""handleSelect"">
            <el-menu-item index=""1"">菜谱</el-menu-item>
            <el-menu-item index=""2"">菜单</el-menu-item>
            <el-menu-item index=""3"">菜单管理</el-menu-item>
            <el-submenu index=""4"">
                <template slot=""title"">我的工作台</template>
                <el-menu-item index=""4-1"">数据编辑</el-menu-item>
                <el-menu-item index=""4-2"">订单数据</el-menu-item>
            </el-submenu>
            
        <div style=""margin: 12px 30px 0 0; float: right;"">
            <el-dropdown ");
                EndContext();
                BeginContext(2602, 190, true);
                WriteLiteral("@command=\"userMethod\">\n              <span class=\"el-dropdown-link\">\n                  <div><el-avatar src=\"https://cube.elemecdn.com/0/88/03b0d39583f48206768a7534e55bcpng.png\"></el-avatar>\n");
                EndContext();
                BeginContext(2865, 656, true);
                WriteLiteral(@"                  </div> 
              </span>
              <el-dropdown-menu slot=""dropdown"">
                <el-dropdown-item command=""edit"">修改信息</el-dropdown-item>
                <el-dropdown-item command=""quit"">退出</el-dropdown-item>
              </el-dropdown-menu>
            </el-dropdown>
            
        </div>
        </el-menu>
        
        
    </div>
    <div id=""container"">
        <el-row style=""height: 100%"">
            <el-col :span=""3"" style=""height: 100%"" v-show=""activeIndex == '1'"">
                <el-menu
                  default-active=""tabIndex""
                  class=""el-menu-vertical-demo""
                  ");
                EndContext();
                BeginContext(3522, 512, true);
                WriteLiteral(@"@select=""selectType"">
                    <el-menu-item index=""all"">
                        <i class=""el-icon-tickets""></i>
                        <span slot=""title"">全部</span>
                    </el-menu-item>
                    <el-menu-item v-for=""(rtype, index) in recipeTypeList"" :index=""rtype.code"" :key=""rtype.code"">
                        <i class=""el-icon-tickets""></i>
                        <span slot=""title"">{{rtype.name}}</span>
                    </el-menu-item>
                </el-menu>
");
                EndContext();
                BeginContext(4360, 238, true);
                WriteLiteral("            </el-col>\n            <el-col :span=\"3\" style=\"height: 100%\" v-show=\"activeIndex == \'4-1\'\">\n                <el-menu\n                    default-active=\"1\"\n                    class=\"el-menu-vertical-demo\"\n                    ");
                EndContext();
                BeginContext(4599, 866, true);
                WriteLiteral(@"@select=""editPageSelect"">
                    <el-menu-item index=""1"">
                        <i class=""el-icon-menu""></i>
                        <span slot=""title"">餐桌编辑</span>
                    </el-menu-item>
                    <el-menu-item index=""2"">
                        <i class=""el-icon-tickets""></i>
                        <span slot=""title"">菜单类型编辑</span>
                    </el-menu-item>
                    <el-menu-item index=""3"">
                        <i class=""el-icon-setting""></i>
                        <span slot=""title"">菜单编辑</span>
                    </el-menu-item>
                </el-menu>
            </el-col>
            <el-col :span=""3"" style=""height: 100%"" v-show=""activeIndex == '4-2'"">
                <el-menu
                    default-active=""1""
                    class=""el-menu-vertical-demo""
                    ");
                EndContext();
                BeginContext(5466, 638, true);
                WriteLiteral(@"@select=""orderListSelect"">
                    <el-menu-item index=""1"">
                        <i class=""el-icon-menu""></i>
                        <span slot=""title"">未支付订单</span>
                    </el-menu-item>
                    <el-menu-item index=""2"">
                        <i class=""el-icon-tickets""></i>
                        <span slot=""title"">搁置订单</span>
                    </el-menu-item>
                    <el-menu-item index=""3"">
                        <i class=""el-icon-setting""></i>
                        <span slot=""title"">已完成订单</span>
                    </el-menu-item>
                </el-menu></el-col>
");
                EndContext();
                BeginContext(6603, 441, true);
                WriteLiteral(@"            <el-col :span=""iframeWidth"" style=""height: 100%"">
                <iframe id=""contentFrame"" v-bind:src=""contentUrl"" scrolling=""auto"" style=""border:none; background-color: #fff; width:100%;height: 100%;""></iframe>
            </el-col>
        </el-row>
        
    </div>
    <div id=""footer"" style=""border-top:1px solid #e6e6e6; height:60px;"">
        <el-row style=""padding: 10px 10px;"">
            <el-button type=""primary"" ");
                EndContext();
                BeginContext(7045, 78, true);
                WriteLiteral("@click=\"submitChecked\">提交菜单</el-button>\n            <el-button type=\"primary\" ");
                EndContext();
                BeginContext(7124, 83, true);
                WriteLiteral("@click=\"removeAllChecked\">取消全部选择</el-button>\n            <el-button type=\"primary\" ");
                EndContext();
                BeginContext(7208, 74, true);
                WriteLiteral("@click=\"refreshRecipe\">刷新</el-button>\n        </el-row>\n    </div>\n</div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7289, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(7680, 5873, true);
            WriteLiteral(@"<script>
    var app = new Vue({
        el: '#app', //DOM中id为app的HTML div标签
        data: {
            activeWindow: 1,
            tabPosition: 'left',
            activeIndex: '1',
            tabIndex: 'all',
            contentUrl: ""/recipe/index"",
            recipeTypeList:[],
            iframeWidth: 21,
            uniqueCode:'',
            tableCode:'',
            circleUrl: 'https://cube.elemecdn.com/3/7c/3ea6beec64369c2642b92c6726f1epng.png',
        },
        methods: {
            userMethod(value) {
                let that = this;
                if(value === 'quit') {
                    $.get(""/Sign/SignOut"", 
                        {}
                    ,function (resp) { 
                        let type = resp.code === 1? 'success' : ""error"";
                        that.alertMessage(type, resp.message);
                        if (resp.code === 1) {
                            setTimeout(function(){
                                window.location = ""/Sign/SignInPage"";
             ");
            WriteLiteral(@"               }, 1500);
                        }
                    }, 'json');
                }else if(value === 'edit') {
                    
                }
                console.log(value);
            },
            orderListSelect:function(tab) {
                var that = this;
                // var time = new Date().getTime();
                if(tab === ""1""){
                    //that.contentUrl = ""/EditData/DinnerTableEdit?time="" + time;
                }else if(tab === ""2""){
                    //that.contentUrl = ""/EditData/RecipeTypeEdit?time="" + time;
                }else if(tab === ""3"") {
                    //that.contentUrl = ""/EditData/RecipeEdit?time="" + time;
                }
            },
            editPageSelect:function(tab){
                var that = this;
                var time = new Date().getTime();
                if(tab === ""1""){
                    that.contentUrl = ""/EditData/DinnerTableEdit?time="" + time;
                }else if(tab === ""2""){
                ");
            WriteLiteral(@"    that.contentUrl = ""/EditData/RecipeTypeEdit?time="" + time;
                }else if(tab === ""3"") {
                    that.contentUrl = ""/EditData/RecipeEdit?time="" + time;
                }
            },
            selectType:function(tab) {
                //debugger;
                var code = tab;
                this.tabIndex = code;
                //debugger;
                document.getElementById(""contentFrame"").contentWindow.app.getTypeRecipes(code);
            },
            alertMessage:function(v_type, v_message, v_ishtml, v_iscenter){
                // var center = true;
                let type, center, message, html;
                if(isEmpty(v_type)) {
                    type = ""success"";
                }else {
                    type = v_type;
                }
                if(isEmpty(v_message)) {
                    message = ""没有提示信息"";
                }else {
                    message = v_message;
                }
                if(isEmpty(v_ishtml)) {
                 ");
            WriteLiteral(@"   html = false;
                }else {
                    html = v_ishtml;
                }
                if(isEmpty(v_iscenter)) {
                    center = true;
                }else {
                    center = v_iscenter;
                }
                this.$message({
                     type: type,
                     center: center,
                     message: message,
                     dangerouslyUseHTMLString: html
                 });
            },
            submitChecked:function(){
                document.getElementById(""contentFrame"").contentWindow.app.submitChecked();
            },
            removeAllChecked:function() {
                document.getElementById(""contentFrame"").contentWindow.app.removeAllChecked();
            },
            refreshRecipe:function() {
                document.getElementById(""contentFrame"").contentWindow.app.refreshRecipe();
                this.GetRecipeTypeList();
            },
            handleSelect:function(key, keyPath){
        ");
            WriteLiteral(@"       // debugger;
                var that = this;
                that.activeIndex = key;
                var time = new Date().getTime();
                if(key === '1') {
                    that.contentUrl = ""/recipe/index?time="" + time;
                    that.iframeWidth = 21;
                }else if(key === '2') {
                    that.contentUrl = ""/menu/index?time="" + time;
                    that.iframeWidth = 24;
                }else if(key === '4-1') {
                    that.contentUrl = ""/editdata/DinnerTableEdit?time="" + time;
                    // that.activeIndex = '4-1';
                    that.iframeWidth = 21;
                }else if(key === '4-2') {
                    that.contentUrl = ""/order/orderdata?time="" + time;
                    that.iframeWidth = 21;
                }
                console.log(key);
            },
            handleChange: function(){},
            resizeWindow:function() {
                var hh = $(""#head"").height();
                var wh = $(");
            WriteLiteral(@"window).height();
                var fh = $(""#footer"").height();
                var ch = wh - hh - fh;
                //debugger;
                $(""#container"").height(ch + ""px""); 
            },
            GetRecipeTypeList: function () {
                var that = this;
                //debugger;
                $.get(""/RecipeType/GetRecipeTypeList"", 
                    {uniqueCode: that.uniqueCode}
                ,function (resp) {         
                    if (resp.code === 1) {
                        that.recipeTypeList = resp.data;
                    }
                }, 'json');
            }
        },
        beforeCreate: function () {
            
        },
        created: function () {
            this.uniqueCode = '");
            EndContext();
            BeginContext(13554, 18, false);
#line 332 "/home/yuluo/WorkSpace/Rider/income/Income/Views/Home/Index.cshtml"
                          Write(ViewBag.UniqueCode);

#line default
#line hidden
            EndContext();
            BeginContext(13572, 604, true);
            WriteLiteral(@"';
            this.GetRecipeTypeList();
        },
        beforeMount: function () {
            
        },
        mounted: function () {
            var that = this;
            that.resizeWindow();
            $(window).resize(function (e) {
                               
                that.resizeWindow();
            });
        },
        beforeUpdate: function () {
           
        },
        updated: function () {
            
        },
        beforeDestroy: function () {
            
        },
        destroyed: function () {
            
        }
    })    
</script>
</html>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
