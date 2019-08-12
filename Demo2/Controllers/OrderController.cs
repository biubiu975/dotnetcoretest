using System;
using System.Collections.Generic;
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
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Controllers
{
//   [Export]
    public class OrderController : BaseController
    {
//        [Import("IRecipeRepository")] 

        private readonly IOrderRepository ORes;

        private readonly IOrderRecipeRepository ORRes;
//

//        public RecipeController()
//        {
//            RecipeRes = new RecipeRepository();
//        }

        // GET
        public OrderController(IOrderRepository ORes, IOrderRecipeRepository ORRes, IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
            this.ORes = ORes;
            this.ORRes = ORRes;
        }

        public IActionResult OrderData()
        {
            return View();
        }

        public JsonResult AddOrder(string uniqueCode, string tableCode, List<RecipeModel> recipes, double allPrice)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                if (ORes.AddOrder(tableCode, recipes, allPrice))
                {
                    return Json(ApiResponse.Success("下单成功"));  
                }
                return Json(ApiResponse.Success("下单失败"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }
//        public IActionResult Index()
//        {
//            return
//            View();
//        }

        public JsonResult GetOrderList(string uniqueCode)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(uniqueCode)) return Json(ApiResponse.Fail("访问错误"));
                if (!IsUniqueCode(uniqueCode)) return Json(ApiResponse.Fail("唯一编码错误"));
                var recipes = RecipeRes.Entities.OrderBy(t => t.ID).ToList();
                return Json(ApiResponse.Success("数据获取成功", recipes));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("服务器错误"));
            }
        }

        
    }
}