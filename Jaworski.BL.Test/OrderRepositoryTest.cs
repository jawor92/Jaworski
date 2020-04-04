using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jaworski.BL;

namespace Jaworski.BL.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void DownloadDataOrderTest()
        {
            //Arrange
            var OrderRepos = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2018, 4, 20, 11, 00, 00, new TimeSpan(7, 0, 0))
            };

            //Action
            var actual = OrderRepos.DownloadData(10);

            //Assert
            Assert.AreEqual(expected.OrderID, actual.OrderID);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
