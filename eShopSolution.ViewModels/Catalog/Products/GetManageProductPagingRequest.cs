using eShopSolution.ViewModels.Common;
using System.Collections.Generic;

namespace eShopSolution.ViewModels.Catalog.Products
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string KeyWord { set; get; }
        public List<int> CategoryIds { set; get; }
    }
}
