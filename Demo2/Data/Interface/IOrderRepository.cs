using System.Collections.Generic;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Interface
{
    public interface IOrderRepository:IRepository<Order>
    {
        bool AddOrder(string tableCode, List<RecipeModel> recipes, double allPrice);
    }
}