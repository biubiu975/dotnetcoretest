#pragma checksum "/home/yuluo/WorkSpace/Rider/income/Income/Views/EditData/RecipeTypeEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11724ebd69cb8cc2f2c619f7e671b17b62df99bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditData_RecipeTypeEdit), @"mvc.1.0.view", @"/Views/EditData/RecipeTypeEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EditData/RecipeTypeEdit.cshtml", typeof(AspNetCore.Views_EditData_RecipeTypeEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11724ebd69cb8cc2f2c619f7e671b17b62df99bf", @"/Views/EditData/RecipeTypeEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7e4fe301a35ef20f5ee89a163529b74b9f60331", @"/Views/_ViewImports.cshtml")]
    public class Views_EditData_RecipeTypeEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 69, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html xmlns:v-bind=\"http://www.w3.org/1999/xhtml\">\n");
            EndContext();
            BeginContext(83, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11724ebd69cb8cc2f2c619f7e671b17b62df99bf3374", async() => {
                BeginContext(89, 52, true);
                WriteLiteral("\n    <meta charset=\"utf-8\">\n    <title>餐桌编辑</title>\n");
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
            BeginContext(148, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(149, 2782, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11724ebd69cb8cc2f2c619f7e671b17b62df99bf4587", async() => {
                BeginContext(155, 625, true);
                WriteLiteral(@"
<style>
.el-table .warning-row {
    background: #EBEEF5;
  }

  .el-table .success-row {
    background: #f2f6fc;
  }
    .time {
        font-size: 13px;
        color: #999;
    }
  
    .bottom {
        margin-top: 13px;
        line-height: 12px;
    }

    .button {
        padding: 0;
        float: right;
    }

    .image {
        width: 100%;
        display: block;
    }

    .clearfix:before,
    .clearfix:after {
        display: table;
        content: """";
    }
  
    .clearfix:after {
        clear: both
    }
</style>
<div id=""app"">
    <div style=""float: right;"">
        <el-button type=""primary"" ");
                EndContext();
                BeginContext(781, 240, true);
                WriteLiteral("@click=\"addRecipeType\" style=\"margin:20px 20px 10px 10px\">添加</el-button>\n        </div>\n    <template>\n        <el-table\n            :data=\"recipeTypes\"\n            style=\"width: 100%\"\n            height=\"650\"\n            max-height=\"650\">\n");
                EndContext();
                BeginContext(1076, 690, true);
                WriteLiteral(@"            <el-table-column
                type=""index""
                label=""序号""
                width=""180""
                align=""center"">
            </el-table-column>
            <el-table-column
                prop=""name""
                label=""名称""
                width=""180""
                align=""center"">
            </el-table-column>
            <el-table-column
                prop=""date""
                label=""日期""
                align=""center"">
            </el-table-column>
            <el-table-column
                label=""操作""
                align=""center"">
                <template slot-scope=""scope"">
                    <el-button type=""warning"" size=""mini"" ");
                EndContext();
                BeginContext(1767, 107, true);
                WriteLiteral("@click=\"editRecipeType(scope.row)\">修改</el-button>\n                    <el-button type=\"danger\" size=\"mini\" ");
                EndContext();
                BeginContext(1875, 323, true);
                WriteLiteral(@"@click=""deleteRecipeType(scope.row)"">删除</el-button>
                </template>
            </el-table-column>
        </el-table>
    </template>
    <template>
        <el-pagination
            background
            layout=""prev, pager, next""
            :total=""totalNum""
            :page-size=""pageSize""
            ");
                EndContext();
                BeginContext(2199, 198, true);
                WriteLiteral("@current-change=\"changePage\">\n        </el-pagination>\n    </template>\n    <Modal\n        :value=\"showAddOrEdit\"\n        :title=\"title\"\n        width=\"500px;\"\n        :mask-closable=\"false\"\n        ");
                EndContext();
                BeginContext(2398, 20, true);
                WriteLiteral("@on-ok=\"ok\"\n        ");
                EndContext();
                BeginContext(2419, 400, true);
                WriteLiteral(@"@on-cancel=""cancel"">
        <el-form v-bind:model=""recipeTypeModel"">
            <el-form-item label=""菜单类型名称："" prop=""name"">
                <el-input v-model=""recipeTypeModel.name"" placeholder=""请输入内容""></el-input>
            </el-form-item>
        </el-form>
    </Modal>
    
    <Modal
        :value=""showDeleted""
        title=""删除""
        width=""500px;""
        :mask-closable=""false""
        ");
                EndContext();
                BeginContext(2820, 28, true);
                WriteLiteral("@on-ok=\"yesDeleted\"\n        ");
                EndContext();
                BeginContext(2849, 75, true);
                WriteLiteral("@on-cancel=\"cancel\">\n        <div>确定删除此条数据么？</div>\n        </Modal>\n</div>\n");
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
            BeginContext(2931, 4957, true);
            WriteLiteral(@"
<script>
    let app = new Vue({
        el: '#app', //DOM中id为app的HTML div标签
        data: {
            showDeleted: false,
            recipeTypes:[],
            totalNum: 100,
            pageSize: 10,
            pageNum: 1,
            showAddOrEdit:false,
            title:'',
            recipeTypeModel:{
                name:"""",
                uniquecode: """",
                code:"""",
                isSaveOrEdit:1, //1save, 2edit
            }
        },
        methods: {
            deleteRecipeType:function(row) {
                debugger;
                let that = this;
                that.showDeleted = true;
                that.recipeTypeModel.code = row.code;
            },
            editRecipeType:function(row) {
                debugger;
                let that = this;
                that.showAddOrEdit = true;
                that.title = ""修改"";
                that.recipeTypeModel.name = row.name;
                that.recipeTypeModel.uniquecode = row.uniqueCode;
                that.");
            WriteLiteral(@"recipeTypeModel.code = row.code;
                that.recipeTypeModel.isSaveOrEdit = 2;
            },
            addRecipeType: function() {
                debugger;
                let that = this;
                that.showAddOrEdit = true;
                that.title = ""添加"";
                that.recipeTypeModel.isSaveOrEdit = 1;
                that.recipeTypeModel.uniquecode = top.app.uniqueCode;
            },
            yesDeleted: function() {
                let that = this;
                $.get(""/RecipeType/deletedRecipeType"", {
                    uniqueCode:top.app.uniqueCode,
                    code: that.recipeTypeModel.code,
                },function (resp) {  
                    let type = resp.code == 1? 'success' : 'error';
                    top.app.alertMessage(type, resp.message);
                    if (resp.code === 1) {
                        // that.pageNum = 1;
                        that.getRecipeTypeList();
                    }
                }, 'json');
                t");
            WriteLiteral(@"his.showDeleted = false;
            },
            ok: function(){
                let that = this;
                let message;
                if(isEmpty(that.recipeTypeModel.name)) {
                    message = ""菜单类型名称不能为空"";
                }
                if(isEmpty(message)) {
                    that.recipeTypeModel.uniquecode = top.app.uniqueCode;
                    $.get(""/RecipeType/AddOrEditRecipeType"", {
                        uniqueCode:top.app.uniqueCode,
                        name: that.recipeTypeModel.name,
                        code: that.recipeTypeModel.code,
                        isSaveOrEdit: that.recipeTypeModel.isSaveOrEdit,
                    },function (resp) {  
                        let type = resp.code == 1? 'success' : 'error';
                        top.app.alertMessage(type, resp.message);
                        if (resp.code === 1) {
                            that.pageNum = 1;
                            that.getRecipeTypeList();
                        }
    ");
            WriteLiteral(@"                }, 'json');
                }else {
                    top.app.alertMessage('warning', message);
                }
                
                this.showAddOrEdit = false;
            },
            cancel:function() {
                this.showAddOrEdit = false;
                this.showDeleted = false;
            },
            changePage:function(page) {
                debugger;
                this.pageNum = page;
                this.getRecipeTypeList();
            },
            getRecipeTypeList: function () {
                let that = this;
                $.get(""/RecipeType/GetRecipeTypeList"", {
                    uniqueCode:top.app.uniqueCode,
                    pageSize: that.pageSize,
                    pageNum: that.pageNum
                },function (resp) {         
                    if (resp.code === 1) {
                        that.recipeTypes = resp.data.recipeTypes;
                        that.totalNum = resp.data.totalNum;
                    }
              ");
            WriteLiteral(@"  }, 'json');
                
            },
            tableRowClassName({row, rowIndex}) {
                let temp = rowIndex % 2;
                if (temp === 0) {
                  return 'warning-row';
                } else if (temp === 1) {
                  return 'success-row';
                }
                return '';
            }
        },
        beforeCreate: function () {
            
        },
        created: function () {
            this.getRecipeTypeList();
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
    })    
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
