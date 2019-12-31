using Microsoft.EntityFrameworkCore;
using SanaEcommerce.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Repositories.Interfaces
{
    public interface ISanaContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<ProductCategory> ProductCategories { get; set; }
        DbSet<Product> Products { get; set; }
        int SaveChanges();
    }
}
