using System;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Requst;
using Demo2.Models.Temp;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class DinnerTableController : BaseController
    {
        private IDinnerTableRepository DTRes;

        // GET
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult deletedDinnerTable(string uniqueCode, string code)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!string.IsNullOrWhiteSpace(code))
                {
                    var result = DTRes.DeletedEntity(code);
                    return Json(ApiResponse.Success("删除成功"));
                }
                return Json(ApiResponse.Fail("数据错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }

        public JsonResult AddOrEditDinnerTable(DinnerTableModel dinnerTableModel)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(dinnerTableModel.uniquecode))
                {
                    var dt = DTRes.Entities.FirstOrDefault(t => t.Name == dinnerTableModel.name && t.IsDeteled == 0 && t.UniqueCode == dinnerTableModel.uniquecode);
                    if (dinnerTableModel.isSaveOrEdit == 1)
                    {
                        if (dt != null) return Json(ApiResponse.Success("数据已存在，不需要重复添加！"));
                        var result = DTRes.AddEntity(dinnerTableModel);
                        return Json(ApiResponse.Success("数据添加成功"));
                    }else if (dinnerTableModel.isSaveOrEdit == 2)
                    {
                        if (dt != null) return Json(ApiResponse.Success("数据已存在，不可以修改！"));
                        var result = DTRes.EditEntity(dinnerTableModel);
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

        public JsonResult GetDinnerTableList(string uniqueCode, int? pageSize = null, int? pageNum = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                var dinnerTables = DTRes.Entities.Where(t=> t.UniqueCode == uniqueCode && t.IsDeteled == 0).OrderByDescending(t => t.Date).Select(dt => new
                {
                    Code = dt.Code,
                    Name = dt.Name,
                    Date = dt.Date.ToString("yyyy-MM-dd HH:mm:ss"),
                    UniqueCode = dt.UniqueCode,
                    Status = dt.Status,
                    ID = dt.ID,
                    IsDeleted = dt.IsDeteled
                }).ToList();
                if (null == pageSize || null == pageNum)
                {
                    return Json(ApiResponse.Success("数据获取成功", dinnerTables));
                }

                int page_size = pageSize.Value;
                int page_num = pageNum.Value - 1;
                int total_num = dinnerTables.Count;
                var list = dinnerTables.Skip(page_num * page_size).Take(page_size).ToList();

                return Json(ApiResponse.Success("数据获取成功", new
                {
                    totalNum = total_num,
                    dinnerTables = list
                }));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }

        public DinnerTableController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes, IDinnerTableRepository DTRes) : base(RecipeRes, MainUserRes)
        {
            this.DTRes = DTRes;
        }
    }
}