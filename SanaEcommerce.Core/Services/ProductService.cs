using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories;
using SanaEcommerce.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SanaEcommerce.Core.Services
{
    /// <summary>
    /// The intent of services is inherit from repository classes and implement their own functionality when necessary (dealing with 2 or more business objects, for example)
    /// </summary>
    public class ProductService: ProductRepository, IProductService
    {
        private readonly static InMemoryProducts _inMemoryStorage = new InMemoryProducts();
        public ProductService(SanaContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Product>> GetAllFromInMemory()
        {
            return await Task.Run(() => _inMemoryStorage.InMemoryProductsList);
        }

        public async Task<Product> GetByIdFromInMemory(int id)
        {
            return await Task.Run(() => _inMemoryStorage.InMemoryProductsList.Find(x => x.Id == id));
        }

        public async Task<bool> SaveToInMemory(Product product)
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
            return await Task.Run(() => result);
        }
    }
}
