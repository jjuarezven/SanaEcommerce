﻿using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanaEcommerce.Core.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SanaContext _context;
        public ProductRepository(SanaContext context)
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
            return _context.SaveChanges() > 0;
        }
    }
}
