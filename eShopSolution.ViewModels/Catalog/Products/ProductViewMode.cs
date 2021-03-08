using System;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class ProductViewMode
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string ImagePath { set; get; }
        public string Caption { set; get; }
        public bool IsDefault { set; get; }
        public DateTime DateCreated { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { set; get; }
        public string LanguageId { set; get; }

        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }

        public int Stock { set; get; }
        public int ViewCont { set; get; }
    }
}
