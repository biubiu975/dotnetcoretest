using System;

namespace Demo2.Models.Temp
{
    public class RecipeModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool check { get; set; }
        public int num { get; set; }
        public int type { get; set; }
        public string url { get; set; }
        public double price { get; set; }
        public string code { get; set; }
        public string date { get; set; }
        public string uniquecode { get; set; }
        public int isSaveOrEdit { get; set; }
        public string fileCode { get; set; }
        public string typeCode { get; set; }
        public int isUse { get; set; }
    }
}