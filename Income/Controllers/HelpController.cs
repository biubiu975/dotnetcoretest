using System;
using ClassLibrary1;
using Demo2.Data.Interface;
using Demo2.Models.Requst;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class HelpController: BaseController
    {

        public IActionResult SearchZiCi()
        {
            return View();
        }

        public IActionResult GetCiYu(string md)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(md))
                {
                    HasCiClass hc = new HasCiClass();
                    var md_ = "包含" + md + "的词语";
                    hc.wd = md_;
                    hc.ReadNum();

                    // if (hc.listNum == 0)
                    // {
                    //     return Json(ApiResponse.Fail("查询失败", new
                    //     {
                    //         listNum = 0,
                    //         result = "",
                    //     }));
                    // }

                    hc.ReadCi();
                    return Json(ApiResponse.Success("查询成功", new
                    {
                        listNum = hc.listNum,
                        result = hc.result,
                    }));
                }

                return Json(ApiResponse.Fail("参数错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("查询失败", new
                {
                    listNum = 0,
                    result = "",
                }));
            }
        }

        public IActionResult GetZi(string md)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(md))
                {
                    HasZiClass hc = new HasZiClass();
                    var md_ = "包含" + md + "的字";
                    hc.wd = md_;
                    hc.ReadNum();
                    // if (hc.listNum == 0)
                    // {
                    //     return Json(ApiResponse.Fail("查询失败", new
                    //     {
                    //         listNum = 0,
                    //         result = "",
                    //     }));
                    // }
                    hc.ReadCi();
                    return Json(ApiResponse.Success("查询成功", new
                    {
                        listNum = hc.listNum,
                        result = hc.result,
                    }));
                }
                
                return Json(ApiResponse.Fail("参数错误"));
            }
            catch (Exception ex)
            {
                return Json(ApiResponse.Fail("查询失败", new
                {
                    listNum = 0,
                    result = "",
                }));
            }
        }

        public HelpController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
        }
    }
}