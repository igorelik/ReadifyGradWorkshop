using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopMVC.Models;

namespace WorkshopMVC.Tests.Models
{
    [TestClass]
    public class SimpleModelTests
    {
        [TestMethod]
        public void GivenObjectCreated_WhenInitialised_ThanNameNicknameSetAsExpected()
        {
            // Arrange
            var model = new SimpleModel();

            // Act
            model.Initialise();

            // Assert
            Assert.AreEqual("A", model.Name, "Name comaprison failed");
            Assert.AreEqual("B", model.Nickname, "NickName comaprison failed");
        }

        [TestMethod]
        public void GivenModelIsInitialised_WhenGettingFullName_ThanDefaultNameReturned()
        {
            // Arrange
            var model = new SimpleModel();
            model.Initialise();

            // Act
            var actual = model.FullName;

            // Assert
            Assert.AreEqual("A - B", actual);
        }
    }
}
