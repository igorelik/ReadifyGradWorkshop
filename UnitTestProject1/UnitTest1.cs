using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;
using WebApplication1.Controllers;
using WebApplication1.Business;

namespace UnitTestProject1
{
    [TestClass]
    public class SimpleModelTests
    {
        HomeController controller;
        [TestInitialize]
        public void INitialise()
        {
            controller = new HomeController(new ModelService());

        }

        [TestMethod]
        public void GivenObjectCreated_WhenInitialised_ThanNicknameSetAsExpected()    // Given_When_Then
        {
            // Arrange
            var model = new SimpleModel();

            // Act
            model.Initialise();

            // Assert
            Assert.AreEqual("Initial Nickname", model.Nickname, "Nickname comparison failed.");
            Assert.AreEqual("Initial Name", model.Name, "Name comparison failed.");
        }

        [TestMethod]
        public void GivenModelIsInitialised_WhenGettingFullName_ThanDefaultNameReturned()
        {
            // Arrange
            var model = new SimpleModel();
            model.Initialise();

            // Act
            var actual = model.Fullname;

            // Assert
            Assert.AreEqual("Initial Name - Initial Nickname", actual);


        }
    }
}
