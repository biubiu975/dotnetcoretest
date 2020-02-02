using ClassLibrary1;
using Demo2.Data.Interface;

namespace Demo2.Controllers
{
    public class HelpController: BaseController
    {
        HasCiClass hc = new HasCiClass();

        public HelpController(IRecipeRepository RecipeRes, IMainUserRepository MainUserRes) : base(RecipeRes, MainUserRes)
        {
        }
    }
}