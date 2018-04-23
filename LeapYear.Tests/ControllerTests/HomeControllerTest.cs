using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using LeapYear.Controllers;
using LeapYear.Models;

namespace LeapYear.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
       public void Index_ReturnsCorrectView_True()
       {
           //Arrange
           HomeController controller = new HomeController();

           //Act
           ActionResult indexView = controller.Index();

           //Assert
           Assert.IsInstanceOfType(result, typeof(ViewResult));
       }
    }
}
