
using Microsoft.EntityFrameworkCore;
using SanaEcommerce.Core.Models;
using SanaEcommerce.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SanaEcommerce.Core.Repositories
{
    public class SanaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        

        public SanaContext(DbContextOptions<SanaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CategoryId = 1, Code = "001", Name = "Laptop", Price = 500, Stock = 66, CreationDate = DateTime.Today },
                new Product { Id = 2, CategoryId = 1, Code = "002", Name = "TV", Price = 300, Stock = 20, CreationDate = DateTime.Today });

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { CategoryId = 1, CategoryName = "Electronics" },
                new ProductCategory { CategoryId = 2, CategoryName = "Garden" },
                new ProductCategory { CategoryId = 3, CategoryName = "Groceries" });
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=sqlitedemo.db");
    }
}
