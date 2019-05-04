using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
    public class CountersControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          CountersController controller = new CountersController();
          ActionResult newView = controller.New();
          Assert.IsInstanceOfType(newView, typeof(ViewResult));
      }
    }
  }
