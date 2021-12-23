using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(24, TestProject1.Program.Cosh(4));
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Math.Round(Math.Sin(30 * Math.PI / 90), 4),
                Math.Round(TestProject1.Program.Cosh(30 * Math.PI / 90), 4));
        }
    }
}
