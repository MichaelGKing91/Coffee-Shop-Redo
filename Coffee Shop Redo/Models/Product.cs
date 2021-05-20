using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Coffee_Shop_Redo.Models
{
    [Table("product")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }

        public override string ToString()
        {
            return $"{id}.) {name} ({description}) ${price:0.00} -- {category}";
        }
    }
}
