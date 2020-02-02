using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Demo2.Models.Entity
{
    [Serializable]
    public class EntityBase
    {
        [Column("code")]
        public string Code { get; set; }
        [Column("is_deleted")]
        public int IsDeteled { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("id")]
        public int ID { get; set; }

        public EntityBase()
        {
            this.Date = DateTime.Now;
            this.IsDeteled = 0;
        }
    }
}