using Demo2.Data.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Demo2.Controllers
{
    public class EditDataController : BaseController
    {
        // GET
        public IActionResult DinnerTableEdit()
        {
            return View();
        }
        public IActionResult RecipeTypeEdit()
        {
            return View();
        }
        public IActionResult RecipeEdit()
        {
            return View();
        }

        public EditDataController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
        }
    }
}