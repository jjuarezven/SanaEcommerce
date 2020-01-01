using SanaEcommerce.Core.Repositories;
using SanaEcommerce.Core.Repositories.Interfaces;
using SanaEcommerce.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Services
{
    public class ProductCategoryService : ProductCategoryRepository, IProductCategoryService
    {
        public ProductCategoryService(SanaContext context): base(context)
        {
        }
    }
}
