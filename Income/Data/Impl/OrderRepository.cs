using System;
using System.Collections.Generic;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Impl
{
    public class OrderRepository:EFRepositoryBase<Order>,IOrderRepository
    {
        
        public OrderRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool AddOrder(string tableCode, List<RecipeModel> recipes, double allPrice)
        {
            using (var dbContextTransaction = dataContext.Database.BeginTransaction())
            {
                try
                {
                    var table = dataContext.Set<DinnerTable>().FirstOrDefault(dt => dt.Code == tableCode);
                    var order = new Order();
                    order.Code = Guid.NewGuid().ToString("D");
                    order.AllPrice = allPrice;
                    order.Status = 1;
                    List < OrderRecipe > orderRecipes = new List<OrderRecipe>();
                    foreach (var recipe in recipes)
                    {
                        var orderRecipe = new OrderRecipe();
                        orderRecipe.Code = Guid.NewGuid().ToString("D");
                        orderRecipe.OrderCode = order.Code;
                        orderRecipe.RecipeCode = recipe.code;
                        orderRecipe.type = 1;
                        orderRecipe.Num = recipe.num;
                        orderRecipes.Add(orderRecipe);
                    }
                    var orderTable = new OrderRecipe();
                    orderTable.Code = Guid.NewGuid().ToString("D");
                    orderTable.Num = 1;
                    orderTable.type = 2;
                    orderTable.OrderCode = order.Code;
                    orderTable.RecipeCode = tableCode;
                    orderRecipes.Add(orderTable);
                    table.Status = 1;
                    dataContext.Set<Order>().Add(order);
                    dataContext.Set<OrderRecipe>().AddRange(orderRecipes);
                    dataContext.Set<DinnerTable>().Update(table);
                    dataContext.SaveChanges();
                    dbContextTransaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }
    }
}