using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Demo2.Data.Interface;
using Microsoft.AspNetCore.Mvc;
using Demo2.Models;
using Demo2.Models.Entity;
using Demo2.Models.Requst;
using Microsoft.AspNetCore.Http;

namespace Demo2.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IMainUserRepository MURes;

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uniqueCode">唯一编码</param>
        /// <returns></returns>
        public IActionResult Index()
        {
            string uniqueCode = HttpContext.Session.GetString("uniqueCode");;
            if (!string.IsNullOrWhiteSpace(uniqueCode))
            {
                var result = IsUniqueCode(uniqueCode);
                if (result)
                {
                    ViewBag.UniqueCode = uniqueCode;
                    return View();
                }
                return Json(ApiResponse.Fail("唯一编码错误"));
            }
            else
            {
                return RedirectToAction("SignInPage", "Sign");//contoller = "Sign", Action = "SignInPage"});
            }

            //return Json(ApiResponse.Fail("访问错误"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public HomeController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
        }
    }
}