using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("recipe_type")]
    public class RecipeType:EntityBase
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("uniquecode")]
        public string UniqueCode { get; set; }
    }
}