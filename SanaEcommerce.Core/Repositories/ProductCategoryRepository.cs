using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanaEcommerce.Core.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly ISanaContext _context;
        public ProductCategoryRepository(ISanaContext context)
        {
            _context = context;
        }

        public Dictionary<int, string> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new { Id = x.CategoryId, Name = x.CategoryName }).ToDictionary(x => x.Id, x => x.Name);
        }
    }
}
