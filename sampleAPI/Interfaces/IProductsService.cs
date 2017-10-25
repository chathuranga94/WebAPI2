using sampleAPI.Models;
using sampleAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleAPI.Interfaces
{
    public interface IProductsService
    {
        GetProductsResponse GetProducts();
        GetProductResponse GetProduct(int id);

    }
}
