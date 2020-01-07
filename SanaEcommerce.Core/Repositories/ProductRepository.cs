using Microsoft.EntityFrameworkCore;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SanaEcommerce.Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SanaContext _context;
        public ProductRepository(SanaContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<bool> Save(Product product)
        {
            await _context.Products.AddAsync(product);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
