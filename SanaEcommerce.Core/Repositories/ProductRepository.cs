using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanaEcommerce.Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISanaContext _context;
        public ProductRepository(ISanaContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.AsEnumerable();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public bool Save(Product product)
        {
            _context.Products.Add(product);
            try
            {
                return _context.SaveChanges() != 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
