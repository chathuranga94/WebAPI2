using sampleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleAPI.Service
{
    public class GetProductResponse
    {
        public bool Success;
        public Product Product;
        public Exception Ex;
    }
}