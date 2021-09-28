using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using webTesting.Controllers;

namespace TestProject1
{
    public class Tests
    {

        //[Test]
        //public void Test1()
        //{
        //    var controller = new HomeController();

        //    var result = controller.Index() as ViewResult;

        //    Assert.AreEqual("Hello World!", result?.ViewData["Message"]);
        //}

        [Test]
        public void Test2()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.AreEqual("Hello World!", result?.ViewData["Message"]);
            Assert.AreNotSame("Hi", result?.ViewData["Message"]);
        }

        [Test]
        public void Test3()
        {
            var controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.IsNull(result);
        }
    }
}