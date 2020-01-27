using EMS_Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            EmployeeController controller = new EmployeeController(new MockRepository());
            // Act
            var result=controller.Index() as ViewResult;
            // Assert
            Assert.Equals("Index", result.ViewName);
        }
    }
}
