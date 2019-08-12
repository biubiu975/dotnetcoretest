using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("order")]
    public class Order:EntityBase
    {
        [Column("status")]
        public int Status { get; set; }
        [Column("allprice")] 
        public double AllPrice { get; set; }
        [Column("table_code")]
        public string TableCode { get; set; }
        [Column("uniquecode")]
        public string UniqueCode { get; set; }
    }
}