using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using sampleAPI.Interfaces;
using sampleAPI.Models;
using sampleAPI.Service;
using sampleAPI.Controllers;
using System.Net.Http;
using System.Web.Http;

namespace sampleAPITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<IProductsService> mock = new Mock<IProductsService>();
            mock.Setup(x => x.GetProduct(It.IsAny<int>())).Returns(new GetProductResponse() { Success = true, Product = new Product() { Category = "Ventas", Id = 1, Name = "Dotnetcore api", Price = 100.83M } });
            var controller = new ProductsController(mock.Object)
            {
                Request = new HttpRequestMessage() { RequestUri = new Uri("http://localhost") }

            };
            controller.Request.SetConfiguration(new HttpConfiguration());
            var response = controller.GetProduct(1);
            Assert.IsNotNull(response);
        }
    }
}
