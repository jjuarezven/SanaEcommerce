using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories;
using SanaEcommerce.Core.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace SanaEcommerce.Core.Services
{
    public class ProductService: ProductRepository, IProductService
    {
        private readonly static InMemoryProducts _inMemoryStorage = new InMemoryProducts();
        public ProductService(SanaContext context) : base(context)
        {
            
        }

        public IEnumerable<Product> GetAllFromInMemory()
        {
            return _inMemoryStorage.InMemoryProductsList;
        }

        public Product GetByIdFromInMemory(int id)
        {
            return _inMemoryStorage.InMemoryProductsList.Find(x => x.Id == id);
        }

        public bool SaveToInMemory(Product product)
        {
            bool result;
            try
            {
                _inMemoryStorage.InMemoryProductsList.Add(product);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
    }
}
