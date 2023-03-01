using Microsoft.AspNetCore.Mvc;
using Moq;
using SportStoreNetCore.Controllers;
using SportStoreNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SportStoreNetCore_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CanUseRepository()
        {
            //Arrange
            //Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            //mock.Setup(a => a.Products).Returns((new Product[]
            //{
            //    new Product { ProductID = 1, Name = "Product_1" },
            //    new Product { ProductID = 2, Name = "Product_2" }
            //}).AsQueryable());

            ////Act
            //HomeController homeController = new HomeController(mock.Object);

            //IEnumerable<Product> sut = (homeController.Index() as ViewResult).ViewData.Model as IEnumerable<Product>;

            ////Assert
            //Product[] prodArrya = sut.ToArray();
            //Assert.True(prodArrya.Length == 2);
            //Assert.Equal("Product_1", prodArrya[0].Name);
            //Assert.Equal("Product_2", prodArrya[1].Name);
        }

        [Fact]
        public void CanPaginate()
        {
            //Arrange
            //Mock<IStoreRepository> mock = new Mock<IStoreRepository>();
            //mock.Setup(a => a.Products).Returns((new Product[]
            //{
            //    new Product { ProductID = 1, Name = "Product_1" },
            //    new Product { ProductID = 2, Name = "Product_2" },
            //    new Product { ProductID = 3, Name = "Product_3" },
            //    new Product { ProductID = 4, Name = "Product_4" },
            //    new Product { ProductID = 5, Name = "Product_5" }
            //}).AsQueryable());

            ////Act
            //HomeController homeController = new HomeController(mock.Object);
            //homeController.pageSize = 3;

            //IEnumerable<Product> sut = (homeController.Index(2) as ViewResult).ViewData.Model as IEnumerable<Product>;

            ////Assert
            //Product[] prodArrya = sut.ToArray();
            //Assert.True(prodArrya.Length == 2);
            //Assert.Equal("Product_4", prodArrya[0].Name);
            //Assert.Equal("Product_5", prodArrya[1].Name);
        }
    }
}
