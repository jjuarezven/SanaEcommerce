using SanaEcommerce.Core.Repositories;
using SanaEcommerce.Core.Services.Interfaces;

namespace SanaEcommerce.Core.Services
{
    public class ProductCategoryService : ProductCategoryRepository, IProductCategoryService
    {
        public ProductCategoryService(SanaContext context): base(context)
        {
        }
    }
}
