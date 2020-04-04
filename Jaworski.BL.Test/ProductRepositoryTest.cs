using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jaworski.BL;

namespace Jaworski.BL.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void DownloadProductTest()
        {
            //Arrange
            var ProductRepos = new ProductRepository();

            var expected = new Product(5)
            {
                NameOfProduct = "Blocks",
                Description = "Blocks for Kids",
                CurrentPrice = 89.99M
            };

            //Act
            var actual = ProductRepos.DownloadData(5);

            //Assert
            Assert.AreEqual(expected.NameOfProduct, actual.NameOfProduct);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
