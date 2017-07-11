using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class SimpleModelTests
    {
        [TestMethod]
        public void GivenObjectCreated_WhenInitialised_ThanNicknameSetAsExpected()    // Given_When_Then
        {
            // Arrange
            var model = new SimpleModel();

            // Act
            model.Initialise();

            // Assert
            Assert.AreEqual("Initial Nickname", model.Nickname);
        }
    }
}
