using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWAPI;
using HWAPI.Controller;

namespace HelloWorld.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloWorld()
        {

            var controller = new HWController();
            var result = controller.Get();
            Assert.IsNotNull(result);
        }
    }
}
