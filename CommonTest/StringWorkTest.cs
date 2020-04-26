using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonTest
{
    [TestClass]
    public class StringWorkTest
    {
        [TestMethod]
        public void WhiteSpaceInsertTest()
        {
            //Arrange
            var source = "GardenTable";

            var expected = "Garden Table";

            var workingString = new StringWork();

            //Act
            var actual = workingString.WhiteSpaceInsert(source);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
