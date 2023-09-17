using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using test2lib;
namespace task2test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "максим";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("привет, максим", res);

        }
    }
}
