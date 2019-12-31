using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Services.Interfaces
{
    /// <summary>
    /// The intent of services is inherit from repository classes and implement their own functionality when necessary (dealing with 2 or more business objects, for example)
    /// </summary>
    public interface IProductService : IProductRepository
    {
    }
}
