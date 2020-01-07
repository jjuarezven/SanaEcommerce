using SanaEcommerce.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SanaEcommerce.Core.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly SanaContext _context;
        public ProductCategoryRepository(SanaContext context)
        {
            _context = context;
        }

        public Dictionary<int, string> GetProductCategories()
        {
            return _context.ProductCategories.Select(x => new { Id = x.CategoryId, Name = x.CategoryName }).ToDictionary(x => x.Id, x => x.Name);
        }
    }
}
