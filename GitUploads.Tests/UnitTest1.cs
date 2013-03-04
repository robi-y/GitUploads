using System;
using System.Web.Mvc;
using GitUploads.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitUploads.Tests
{
    [TestClass]
    public class UploadControllerTests
    {
        [TestMethod]
        public void CorrectMessageOnMainScreen()
        {
            //Arrange
            var controller = new UploadController();

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual("Please upload your file...", result.ViewBag.Message);
        }
    }
}
