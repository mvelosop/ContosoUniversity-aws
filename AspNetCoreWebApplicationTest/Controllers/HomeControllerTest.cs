using AspNetCoreWebApplication.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApplicationTest.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult) controller.Index();
            Assert.Equal(1, result.ViewData.Count);
            Assert.Equal("You just created a ASP.Net Core web application!", result.ViewData["Message"]);
        }

        [Fact]
        public void ErrorTest()
        {
            HomeController controller = new HomeController();
            ViewResult result = (ViewResult)controller.Error();
            Assert.Equal(1, result.ViewData.Count);
            Assert.Equal("We've encountered an error :(", result.ViewData["Message"]);
        }
    }
}
