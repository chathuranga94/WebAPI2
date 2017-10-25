using sampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleAPI.Repository
{
    public class ProductRepository
    {

        public Product[] GetAllProducts()
        {
            return new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };
        }



        public Product GetProduct(int id)
        {
            var products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };
            return products.FirstOrDefault((p) => p.Id == id);
        }

    }
}