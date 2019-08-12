using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("main_user")]
    public class MainUser:EntityBase
    {
        [Column("username")]
        public string Username { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("uniquecode")]
        public string Uniquecode { get; set; }
    }
}