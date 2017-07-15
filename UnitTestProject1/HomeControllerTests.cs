using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication1.Business;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class HomeControllerTests
    {
        HomeController controller;
        Mock<IModelService> modelServiceMock;

        [TestInitialize]
        public void Initialise()
        {
            modelServiceMock = new Mock<IModelService>();
            controller = new HomeController(modelServiceMock.Object);
        }


        [TestMethod]
        public void TestModel()
        {
            // Arrange
            modelServiceMock.Setup(m => m.GetEmpty())    // Essentially reimplement a function to reduce load. e.g. The function might contact a database, so instead of doing that, return something simple.
                .Returns(new SimpleModel());

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "result null");
            Assert.IsNotNull(result.ViewBag.Model, "viewBag MOdel null");
            var model = result.ViewBag.Model as SimpleModel;
            Assert.IsTrue(string.IsNullOrEmpty(model.Name), "Name not null");
        }
    }
}
