using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Requst;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class BaseController : Controller
    {
        public readonly IRecipeRepository RecipeRes;
        public readonly IMainUserRepository MainUserRes;

        public BaseController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes)
        {
            this.RecipeRes = RecipeRes;
            this.MainUserRes = MainUserRes;
        }

        // GET
        public bool IsUniqueCode(string uniqueCode)
        {
            var mainUser = MainUserRes.Entities.FirstOrDefault(mu => mu.UniqueCode == uniqueCode);
            if (mainUser == null)
            {
                return false;
            }
            return true;
        }

        public bool IsLogin(MainUser mainUser)
        {
            return false;
        }

        public MainUser CurrentUser(string uniqueCode)
        {
            var mainUser = MainUserRes.Entities.FirstOrDefault(mu => mu.UniqueCode == uniqueCode);
            return mainUser;
        }
    }
}