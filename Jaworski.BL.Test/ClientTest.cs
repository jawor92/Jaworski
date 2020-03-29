using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jaworski.BL;

namespace Jaworski.BL.Test
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void NameLastNameTest()
        {
            //1 Step - Arrange test (test preparation)
            Client client = new Client();

            client.Name = "Mateusz";
            client.LastName = "Jaworski";

            string expected = "Mateusz, Jaworski";

            //2 Step - Action
            string actual = client.NameLastName;

            //3 Step - Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NameLastName_EmptyNameTest()
        {
            //1 Step - Arrange test (test preparation)
            Client client = new Client();

            client.LastName = "Jaworski";

            string expected = "Jaworski";

            //2 Step - Action
            string actual = client.NameLastName;

            //3 Step - Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NameLastName_EmptyLastNameTest()
        {
            //1 Step - Arrange test (test preparation)
            Client client = new Client();

            client.Name = "Mateusz";
            client.LastName = "Jaworski";

            string expected = "Mateusz, Jaworski";

            //2 Step - Action
            string actual = client.NameLastName;

            //3 Step - Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //1 Step - Arrange test (test preparation)
            var Client1 = new Client();
            Client1.Name = "Mateusz";
            Client.Counter += 1; //"static" mod - only to class, no to property

            var Client2 = new Client();
            Client2.Name = "Jacek";
            Client.Counter += 1;

            var Client3 = new Client();
            Client3.Name = "Irek";
            Client.Counter += 1;

            //2 Step - Action

            //3 Step - Assert
            Assert.AreEqual(3, Client.Counter);

        }
    }
}
