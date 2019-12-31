using SanaEcommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        bool Save(Product product);
    }
}
