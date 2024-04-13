using System.Security.Claims;
using MvcMovie.Controllers;
using System.Diagnostics;

namespace MvcMovie.UnitTests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void Index_should_return_correct_view_to_user()
        {
            var controller = new HomeController(null);
            var result = controller.Index() as Microsoft.AspNetCore.Mvc.ViewResult;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.ViewName == "Index" ||
                string.IsNullOrEmpty(result.ViewName));
        }
        [TestMethod]
        public void Privacy_should_return_correct_view_to_user()
        {
            var controller = new HomeController(null);

            var result = controller.Privacy() as Microsoft.AspNetCore.Mvc.ViewResult;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.ViewName == "Privacy" ||
                string.IsNullOrEmpty(result.ViewName));
        }
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}