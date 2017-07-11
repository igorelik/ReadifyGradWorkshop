using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopMVC;
using WorkshopMVC.Controllers;
using WorkshopMVC.Models;
using WorkshopMVC.Business;
using Moq;

namespace WorkshopMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController _controller;
        Mock<IModelService> _modelServiceMock;
        [TestInitialize]
        public void Initiaslise()
        {
            _modelServiceMock = new Mock<IModelService>();
            _controller = new HomeController(_modelServiceMock.Object);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange

            // Act
            ViewResult result = _controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
 
            // Act
            ViewResult result = _controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            _modelServiceMock.Setup(m => m.GetEmptyModel())
                           .Returns(new SimpleModel());

            // Act
            ViewResult result = _controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Contact() retiurns NULL");
            Assert.IsNotNull(result.ViewBag.Model, "ViewBag.Model is NULL");
            var model = result.ViewBag.Model as SimpleModel;
            Assert.IsTrue(string.IsNullOrEmpty(model.Name), "Name doesn't match");
        }
    }
}
