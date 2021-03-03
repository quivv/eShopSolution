using eShopSolution.Application.Catalog.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { set; get; }

        public List<int> CategoryIds { set; get; }
    }
}
