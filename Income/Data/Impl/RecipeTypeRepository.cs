using System;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Impl
{
    
    
    public class RecipeTypeRepository:EFRepositoryBase<RecipeType>,IRecipeTypeRepository
    {
        public RecipeTypeRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool AddEntity(RecipeTypeModel recipeTypeModel)
        {
            try
            {
                RecipeType recipeType = new RecipeType();
                recipeType.Code = Guid.NewGuid().ToString("D");
                recipeType.UniqueCode = recipeTypeModel.uniquecode;
               // recipeType.Status = 0;
                recipeType.Name = recipeTypeModel.name;
                recipeType.Date = DateTime.Now;
                
                return Add(recipeType);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditEntity(RecipeTypeModel recipeTypeModel)
        {
            try
            {
                var recipeType = Entities.FirstOrDefault(dt => dt.Code == recipeTypeModel.code && dt.IsDeteled == 0);
                recipeType.Name = recipeTypeModel.name;
                return Update(recipeType);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletedEntity(string code)
        {
            try
            {
                var recipeType = Entities.FirstOrDefault(dt => dt.Code == code && dt.IsDeteled == 0);
                recipeType.IsDeteled = 1;
                return Update(recipeType);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}