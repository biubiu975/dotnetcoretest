using System.Linq;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Interface
{
    public interface IRecipeRepository:IRepository<Recipe>
    {
        bool AddEntity(RecipeModel recipeModel);
        bool EditEntity(RecipeModel recipeModel);
        bool DeletedEntity(string uniqueCode, string code);
        bool IsUseEntity(string uniqueCode, string code);
    }
}