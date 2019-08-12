using System;
using Microsoft.AspNetCore.Mvc;
using System.Configuration;
using System.Linq;
using Demo2.Models.Requst;
using System.ComponentModel.Composition;
using Demo2.Data.Interface;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Demo2.Data.Impl;
using Demo2.Models.Temp;

namespace Demo2.Controllers
{
    public class RecipeController : BaseController
    {

//        private IRecipeRepository RRes;
        public RecipeController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
//            this.RRes = RecipeRes;
        }
        public IActionResult Index()
        {
            return
            View();
        }

        public JsonResult GetRecipeList_Index(string uniqueCode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                var recipes = RecipeRes.Entities.Where(r => r.UniqueCode == uniqueCode && r.IsDeteled == 0 && r.IsUse == 1).OrderByDescending(r => r.Date).Select(r => new RecipeModel
                {
                    name = r.Name,
                    url = r.Url,
                    code = r.Code,
                    price = r.Price,
                    typeCode = r.TypeCode,
                    date = r.Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    check = false,
                    isUse = r.IsUse
                }).ToList();
                
                return Json(ApiResponse.Success("数据获取成功", recipes));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
        
        
        public JsonResult GetRecipeList(string uniqueCode, int? pageSize = null, int? pageNum = null, string typeCode = null, string name = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                var recipes = RecipeRes.Entities.Where(r => r.UniqueCode == uniqueCode && r.IsDeteled == 0).OrderByDescending(r => r.Date).Select(r => new RecipeModel
                {
                    name = r.Name,
                    url = r.Url,
                    code = r.Code,
                    price = r.Price,
                    typeCode = r.TypeCode,
                    date = r.Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    check = false,
                    isUse = r.IsUse
                }).ToList();

                if (!string.IsNullOrWhiteSpace(typeCode))
                {
                    recipes = recipes.Where(r => r.typeCode == typeCode).ToList();
                }

                if (!string.IsNullOrWhiteSpace(name))
                {
                    recipes = recipes.Where(r => r.name.Contains(name)).ToList();
                }

                if (null == pageSize || null == pageNum)
                {
                    return Json(ApiResponse.Success("数据获取成功", recipes));
                }
                int page_size = pageSize.Value;
                int page_num = pageNum.Value - 1;
                int total_num = recipes.Count;
                var list = recipes.Skip(page_num * page_size).Take(page_size).ToList();
                return Json(ApiResponse.Success("数据获取成功", new
                {
                    totalNum = total_num,
                    recipes = list
                }));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
        
        public JsonResult AddOrEditRecipe(RecipeModel recipeModel)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(recipeModel.uniquecode))
                {
                    var dt = RecipeRes.Entities.FirstOrDefault(t => t.Name == recipeModel.name && t.IsDeteled == 0 && t.UniqueCode == recipeModel.uniquecode);
                    if (recipeModel.isSaveOrEdit == 1)
                    {
                        if (dt != null) return Json(ApiResponse.Success("数据已存在，不需要重复添加！"));
                        var result = RecipeRes.AddEntity(recipeModel);
                        return Json(ApiResponse.Success("数据添加成功"));
                    }else if (recipeModel.isSaveOrEdit == 2)
                    {
                        //if (dt != null) return Json(ApiResponse.Success("数据已存在，不可以修改！"));
                        var result = RecipeRes.EditEntity(recipeModel);
                        return Json(ApiResponse.Success("数据修改成功"));
                    }

                    
                }
                return Json(ApiResponse.Fail("数据实体出错"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
        
        public JsonResult deletedRecipe(string uniqueCode, string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!string.IsNullOrWhiteSpace(code))
                {
                    if (RecipeRes.DeletedEntity(uniqueCode, code))
                    {
                        return Json(ApiResponse.Success("删除成功"));
                    }
                    return Json(ApiResponse.Success("删除失败"));
                    
                }
                return Json(ApiResponse.Fail("数据错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
        
        public JsonResult IsUseRecipe(string uniqueCode, string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!string.IsNullOrWhiteSpace(code))
                {
                    if (RecipeRes.IsUseEntity(uniqueCode, code))
                    {
                        return Json(ApiResponse.Success("操作成功"));
                    }
                    return Json(ApiResponse.Success("操作失败"));
                    
                }
                return Json(ApiResponse.Fail("数据错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
    }
}