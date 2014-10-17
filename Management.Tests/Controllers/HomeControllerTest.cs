using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Management.Web.Controllers;
using System.Web.Mvc;

namespace Management.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        HomeController controller;

        [SetUp]
        public void SetUp()
        {
            controller = new HomeController();
        }
        
        [Test]
        public void IndexTest()
        {
            var result = controller.Index() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
