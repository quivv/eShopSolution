using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public int Quantity { set; get; }
        public decimal Price { set; get; }
        public Guid UserId { set; get; } 
        public DateTime DateCreated { set; get; } 

        public Product Product { set; get; }

        public AppUser AppUser { set; get; }
    }
}
