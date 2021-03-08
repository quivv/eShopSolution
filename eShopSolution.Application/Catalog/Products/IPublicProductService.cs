using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewMode>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewMode>> GetAll();
    }
}
