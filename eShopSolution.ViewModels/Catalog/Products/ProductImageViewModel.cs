using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductImageViewModel
    {
        public int Id { set; get; }
        public string FilePath { set; get; }
        public bool IsDefault { set; get; }
        public long File { set; get; }
    }
}
