using System;
using System.ComponentModel.Composition;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Temp;
using Microsoft.EntityFrameworkCore;

namespace Demo2.Data.Impl
{
//    [Export("IRecipeRepository", typeof(IRecipeRepository))]
    public class RecipeRepository:EFRepositoryBase<Recipe>,IRecipeRepository
    {
        public RecipeRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool AddEntity(RecipeModel recipeModel)
        {
            try
            {
                var recipe = new Recipe
                {
                    Name = recipeModel.name,
                    Code = Guid.NewGuid().ToString("D"),
                    Url = recipeModel.url,
                    Date = DateTime.Now,
                    Price = recipeModel.price,
                    TypeCode = recipeModel.typeCode,
                    UniqueCode = recipeModel.uniquecode
                };

                return Add(recipe);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditEntity(RecipeModel recipeModel)
        {
            try
            {
                var recipe = Entities.FirstOrDefault(r =>
                    r.Code == recipeModel.code && r.IsDeteled == 0 && r.UniqueCode == recipeModel.uniquecode);
                if (null != recipe)
                {
                    recipe.Name = recipeModel.name;
                    recipe.Url = recipeModel.url;
                    recipe.Price = recipeModel.price;
                    recipe.TypeCode = recipeModel.typeCode;
                }

                return Update(recipe);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletedEntity(string uniqueCode, string code)
        {
            try
            {
                var recipe = Entities.FirstOrDefault(r =>
                    r.Code == code && r.IsDeteled == 0 && r.UniqueCode == uniqueCode);
                if (null != recipe)
                {
                    recipe.IsDeteled = 1;
                    return Update(recipe);
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsUseEntity(string uniqueCode, string code)
        {
            try
            {
                var recipe = Entities.FirstOrDefault(r =>
                    r.Code == code && r.IsDeteled == 0 && r.UniqueCode == uniqueCode);
                if (null != recipe)
                {
                    if (recipe.IsUse == 1)
                    {
                        recipe.IsUse = 0;
                    }else if (recipe.IsUse == 0)
                    {
                        recipe.IsUse = 1;
                    }

                    return Update(recipe);
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}