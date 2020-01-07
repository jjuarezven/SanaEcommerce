using System.Collections.Generic;

namespace SanaEcommerce.Core.Repositories.Interfaces
{
    public interface IProductCategoryRepository
    {
        Dictionary<int, string> GetProductCategories();
    }
}
