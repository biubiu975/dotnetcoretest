using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("recipe")]
    public class Recipe:EntityBase
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("type_code")]
        public string TypeCode { get; set; }
        [Column("url")]
        public string Url { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("uniquecode")]
        public string UniqueCode { get; set; }
        [Column("is_use")]
        public int IsUse { get; set; }
    }
}