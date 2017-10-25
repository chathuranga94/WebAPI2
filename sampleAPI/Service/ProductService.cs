using sampleAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sampleAPI.Models;
using sampleAPI.Repository;

namespace sampleAPI.Service
{
    public class ProductService : IProductsService
    {
        public GetProductResponse GetProduct(int id)
        {
            var result = new GetProductResponse();
            try
            {
                result.Success = true;
                result.Product = new ProductRepository().GetProduct(id);
            }
            catch (Exception ex)
            {
                result.Success = false;
                //TODO : get a logger nuget
                Console.WriteLine(string.Format("Exception Catched to log {0}", ex));
            }
            return result;
        }



        public GetProductsResponse GetProducts()
        {
            var result = new GetProductsResponse();
            try
            {
                result.Success = true;
                result.Products = new ProductRepository().GetAllProducts();
            }
            catch (Exception ex)
            {
                result.Success = false;
                //TODO : get a logger nuget
                Console.WriteLine(string.Format("Exception Catched to log {0}", ex));
            }
            return result;
        }


    }
}