using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Hello hello = new Hello();
            int value = hello.getInt();
            Assert.AreEqual(1, value);
        }
    }
}
