using SanaEcommerce.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SanaEcommerce.Core.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> Save(Product product);
    }
}
