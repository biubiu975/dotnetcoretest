using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("dinner_table")]
    public class DinnerTable:EntityBase
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("uniquecode")]
        public string UniqueCode { get; set; }
    }
}