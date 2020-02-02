using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Requst;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI;

namespace Demo2.Controllers
{
    public class SignController : Controller
    {
        private readonly IMainUserRepository MainUserRes;
        public SignController(IMainUserRepository MainUserRes)
        {
            this.MainUserRes = MainUserRes;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        //登录页面
        public IActionResult SignInPage()
        {
            return View();
        }
        
        //注册页面
        public IActionResult SignUpPage()
        {
            return View();
        }
        
        //登录
        public IActionResult SignIn(string username, string password, bool isRemember)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                var md5 = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
                var md5_password = BitConverter.ToString(md5).Replace("-", "");
                var result = MainUserRes.Entities.FirstOrDefault(u => u.Username == username && u.Password == md5_password);
                if (result != null)
                {
                    // HttpContext.Session.Set("password", Encoding.Default.GetBytes( password));
                    HttpContext.Session.SetString("username", username);
                    HttpContext.Session.SetString("password", password);
                    HttpContext.Session.SetString("uniqueCode", result.UniqueCode);
                    if(isRemember)
                        Response.Cookies.Append("user", username + "-" + password + "-" + isRemember);
                    else
                        Response.Cookies.Append("user", "");
                    
                    return Json(ApiResponse.Success("登录成功"));
                }
                return Json(ApiResponse.Fail("用户名或密码错误"));
            }

            return Json(ApiResponse.Fail("访问错误"));
        }
        
        //登录
        public IActionResult SignOut()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("password");
            HttpContext.Session.Remove("uniqueCode");
            return Json(ApiResponse.Success("退出成功"));
        }
        
        //注册
        public IActionResult SignUp(string username, string password)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                var result = MainUserRes.Entities.FirstOrDefault(u => u.Username == username && u.IsDeteled == 0);
                var md5 = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password));
                var md5_password = BitConverter.ToString(md5).Replace("-", "");
                
                if (result == null)
                {
                    var code = Guid.NewGuid().ToString("D");
                    var user = new MainUser()
                    {
                        Username = username,
                        Password = md5_password,
                        Code = code,
                        UniqueCode = code,//暂时使用,后期调整
                    };
                    if (MainUserRes.SignUpMainUser(user))
                    {
                        return Json(ApiResponse.Success("注册成功"));
                    }
                    return Json(ApiResponse.Fail("注册失败"));
                }
            }
            return Json(ApiResponse.Fail("访问错误"));
        }
    }
}