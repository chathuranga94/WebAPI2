using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using sampleAPI.Models;
using sampleAPI.Interfaces;

namespace sampleAPI.Controllers
{
    public class ProductsController : ApiController
    {
        IProductsService _service = null;
        public ProductsController(IProductsService service)
        {
            _service = service;
        }
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };

        public IHttpActionResult GetProduct(int id)
        {
            var product = _service.GetProduct(id);
            if (product.Success)
            {
                if (product.Product!=null)
                {
                    return Ok(product.Product);
                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return StatusCode(HttpStatusCode.InternalServerError);
            }

        }
    


        public IHttpActionResult GetAllProducts()
        {
            var products = _service.GetProducts();
            if (products.Success)
            {
                if (products.Products.Length > 0)
                {
                    return Ok(products.Products);
                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return StatusCode(HttpStatusCode.InternalServerError);
            }

        }
    }
}
