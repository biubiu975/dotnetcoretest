using System;

namespace Demo2.Models.Temp
{
    public class DinnerTableModel
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public int is_deleted { get; set; }
        public string uniquecode { get; set; }
        public int isSaveOrEdit { get; set; }
    }
}