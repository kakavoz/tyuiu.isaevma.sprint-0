using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task3lib;

namespace task3test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
