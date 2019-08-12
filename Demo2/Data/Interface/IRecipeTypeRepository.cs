using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Interface
{
    public interface IRecipeTypeRepository:IRepository<RecipeType>
    {
        bool AddEntity(RecipeTypeModel recipeTypeModel);
        bool EditEntity(RecipeTypeModel recipeTypeModel);
        bool DeletedEntity(string code);
    }
}