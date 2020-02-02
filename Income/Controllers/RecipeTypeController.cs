using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Requst;
using Demo2.Models.Temp;

namespace Demo2.Controllers
{
    public class RecipeTypeController : BaseController
    {
        private readonly IRecipeTypeRepository RTRes;

       
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetRecipeTypeList(string uniqueCode, int? pageSize = null, int? pageNum = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                var recipeTypes = RTRes.Entities.Where(t => t.UniqueCode == uniqueCode && t.IsDeteled == 0).OrderByDescending(t => t.ID).Select(t => new RecipeTypeModel
                {
                    name = t.Name,
                    code = t.Code,
                    uniquecode = t.UniqueCode,
                    is_deleted = t.IsDeteled,
                    date = t.Date.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();
                if (null == pageSize || null == pageNum)
                {
                    return Json(ApiResponse.Success("数据获取成功", recipeTypes));
                }
                int page_size = pageSize.Value;
                int page_num = pageNum.Value - 1;
                int total_num = recipeTypes.Count;
                var list = recipeTypes.Skip(page_num * page_size).Take(page_size).ToList();

                return Json(ApiResponse.Success("数据获取成功", new
                {
                    totalNum = total_num,
                    recipeTypes = list
                }));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }

        public JsonResult deletedRecipeType(string uniqueCode, string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!string.IsNullOrWhiteSpace(code))
                {
                    var result = RTRes.DeletedEntity(code);
                    return Json(ApiResponse.Success("删除成功"));
                }
                return Json(ApiResponse.Fail("数据错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }

        public JsonResult AddOrEditRecipeType(RecipeTypeModel recipeTypeModel)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(recipeTypeModel.uniquecode))
                {
                    var dt = RTRes.Entities.FirstOrDefault(t => t.Name == recipeTypeModel.name && t.IsDeteled == 0 && t.UniqueCode == recipeTypeModel.uniquecode);
                    if (recipeTypeModel.isSaveOrEdit == 1)
                    {
                        if (dt != null) return Json(ApiResponse.Success("数据已存在，不需要重复添加！"));
                        var result = RTRes.AddEntity(recipeTypeModel);
                        return Json(ApiResponse.Success("数据添加成功"));
                    }else if (recipeTypeModel.isSaveOrEdit == 2)
                    {
                        if (dt != null) return Json(ApiResponse.Success("数据已存在，不可以修改！"));
                        var result = RTRes.EditEntity(recipeTypeModel);
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
        
        public RecipeTypeController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes, IRecipeTypeRepository RTRes) : base(RecipeRes, MainUserRes)
        {
            this.RTRes = RTRes;
        }
    }
}