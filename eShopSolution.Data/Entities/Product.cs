using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Product
    {
        public string Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCont { set; get; }
        public DateTime DateCreated { set; get; }
        public bool? IsFeatured { set; get; }
    }
}
