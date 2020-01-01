using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SanaEcommerce.Core.Models
{
	public class InMemoryProducts
	{
		public List<Product> InMemoryProductsList { get; set; }
		public List<ProductCategory> InMemoryProductsCategories { get; set; }

		public InMemoryProducts()
		{
			InMemoryProductsCategories = new List<ProductCategory> { new ProductCategory { CategoryId = 1, CategoryName = "Electronics" },
				new ProductCategory { CategoryId = 2, CategoryName = "Garden" },
				new ProductCategory { CategoryId = 3, CategoryName = "Groceries" } };

			InMemoryProductsList = new List<Product>
			{
				new Product
				{
					CategoryId = 1,
					Code = "0025",
					Name = "DVD player",
					Price = 74,
					Stock = 7,
					CreationDate = DateTime.Today,
					ProductCategory = InMemoryProductsCategories.First()
				}
			};

		}
	}
}
