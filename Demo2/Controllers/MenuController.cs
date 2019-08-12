using System;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Requst;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class MenuController : BaseController
    {
        private readonly IOrderRepository ORes;
        private readonly IOrderRecipeRepository ORRes;
        private readonly IDinnerTableRepository DTRes;
        private readonly IRecipeRepository RRes;
        private readonly IRecipeTypeRepository RTRes;
        // GET
        public IActionResult Index()
        {
            return
            View();
        }

        public JsonResult GetMenuList(string tableCode, string uniqueCode)
        {
            try
            {
                var resp = new ApiResponse();
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                if (!string.IsNullOrWhiteSpace(tableCode))
                {
                    var menu = (from a in ORes.Entities.Where(o =>
                            o.UniqueCode == uniqueCode && o.TableCode == tableCode)
                        join b in ORRes.Entities on a.Code equals b.OrderCode
                        join d in RRes.Entities on b.RecipeCode equals d.Code
                        join e in RTRes.Entities on d.TypeCode equals e.Code
                            join c in DTRes.Entities on a.TableCode equals c.Code
                            select new
                            {
                                tableName= c.Name,
                                tableCode = c.Code,
                                orderCode = a.Code,
                                recipeName = d.Name,
                                recipeCode = d.Code,
                                recipeType = e.Name,
                                typeCode = e.Code
                            }).ToList();
                    resp.Code = 1;
                    resp.Data = menu;
                }

                return Json(resp);
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));   
            }
        }

        public MenuController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes, 
            IOrderRepository ORes, IOrderRecipeRepository ORRes,
            IDinnerTableRepository DTRes, IRecipeRepository RRes,
            IRecipeTypeRepository RTRes) : base(RecipeRes, MainUserRes)
        {
            this.ORes = ORes;
            this.ORRes = ORRes;
            this.DTRes = DTRes;
            this.RRes = RRes;
            this.RTRes = RTRes;
        }
    }
}