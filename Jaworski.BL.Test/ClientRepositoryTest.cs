using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jaworski.BL;

namespace Jaworski.BL.Test
{
    [TestClass]
    public class ClientRepositoryTest
    {
        [TestMethod]
        public void DownloadDataClientTest()
        {
            //Arrange
            var ClientRepos = new ClientRepository();

            var expected = new Client(1)
            {
                Email = "test@test.gmail.com",
                Name = "Mateusz",
                LastName = "Jaworski"
            };

            //Action
            var actual = ClientRepos.DownloadData(1);

            //Assert
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
