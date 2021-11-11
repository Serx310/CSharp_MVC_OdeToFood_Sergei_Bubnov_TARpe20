﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood_Test.Controllers
{
    [TestClass]
    class HomeControllerTest
    {
        [TestMethod]
        public void About()
        {
            using var logFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = logFactory.CreateLogger<HomeController>();
            //Arrange
            HomeController controller = new HomeController(logger);

            //Act
            ViewResult result = controller.About() as ViewResult;

            Assert.IsNotNull(result.Model);
        }
    }
}