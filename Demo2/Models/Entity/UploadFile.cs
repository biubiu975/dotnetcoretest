using System.ComponentModel.DataAnnotations.Schema;

namespace Demo2.Models.Entity
{
    [Table("upload_file")]
    public class UploadFile:EntityBase
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("uniquecode")]
        public string UniqueCode { get; set; }
        [Column("data_name")]
        public string DataName { get; set; }
        [Column("file_path")]
        public string FilePath { get; set; }
        [Column("file_hash")]
        public string FileHash { get; set; }
    }
}