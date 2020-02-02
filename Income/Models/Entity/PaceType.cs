using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("pace_type")]
    public class PaceType:EntityBase
    {
        [Column("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// 1未完成 2搁置 3完成
        /// </summary>
        [Column("type")]
        public int Type { get; set; }
    }
}