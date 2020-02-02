using Demo2.Data.Interface;
using Demo2.Models.Entity;

namespace Demo2.Data.Impl
{
    
    
    public class OrderRecipeRepository:EFRepositoryBase<OrderRecipe>,IOrderRecipeRepository
    {
        public OrderRecipeRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}