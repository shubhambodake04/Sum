using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sum;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program program = new Program();
            int result = program.Add(2, 5);
            Assert.AreEqual(7, result);
        }
        public void TestMethod2()
        {
            Program program = new Program();
            int result = program.Add(2, 10);
            Assert.AreEqual(12, result);
        }
        public void TestMethod3()
        {
            Program program = new Program();
            int result = program.Add(2, 10);
            Assert.AreEqual(12, result);
        }
    }
}
