using sampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleAPI.Service
{
    public class GetProductsResponse
    {
        public bool Success;
        public Product[] Products;
        public Exception Ex;
    }
}