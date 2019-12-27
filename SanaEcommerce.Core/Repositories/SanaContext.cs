using Microsoft.EntityFrameworkCore;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Repositories
{
    public class SanaContext : DbContext, ISanaContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public SanaContext(DbContextOptions<SanaContext> options) : base(options)
        {

        }
    }
}
