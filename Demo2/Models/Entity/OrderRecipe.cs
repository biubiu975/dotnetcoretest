using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("order_recipe")]
    public class OrderRecipe:EntityBase
    {
        [Column("order_code")]
        public string OrderCode { get; set; }
        [Column("recipe_code")]
        public string RecipeCode { get; set; }
        [Column("type")]
        public int type { get; set; }
        [Column("num")]
        public int Num { get; set; }
    }
}