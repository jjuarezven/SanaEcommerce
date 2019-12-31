using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Repositories.Interfaces
{
    public interface IProductCategoryRepository
    {
        Dictionary<int, string> GetProductCategories();
    }
}
