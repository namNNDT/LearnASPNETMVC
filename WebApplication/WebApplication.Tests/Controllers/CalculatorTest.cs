using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.Controllers;
using System.Web.Mvc;

namespace WebApplication.Tests.Controllers
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestIndex()
        {
              // Arrange
          var controller = new CalculatorController();

            // Act
          var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
        }

        }
    }

