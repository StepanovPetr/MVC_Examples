using System.Web.Mvc;
using NUnit.Framework;
using Redirect.Controllers;

namespace NUnitTestsExampleRedirectController
{
    [TestFixture]
    public class UnitTestsExampleRedirectController
    {
        [Test]
        public void TestRedirec1()
        {
            ExampleRedirectController exampleRedirectController = new ExampleRedirectController();
            RedirectResult actionResult = (RedirectResult)exampleRedirectController.Redirec1();
            Assert.IsTrue(actionResult.Url.Contains("http://www.google.ru"));
        }

        [Test]
        public void TestRedirec2()
        {
            ExampleRedirectController exampleRedirectController = new ExampleRedirectController();
            RedirectToRouteResult actionResult = (RedirectToRouteResult)exampleRedirectController.Redirec2();
            string action =  actionResult.RouteValues["action"].ToString();
            Assert.IsTrue(action.Contains("Index"));
        }

        [Test]
        public void TestRedirec3()
        {
            ExampleRedirectController exampleRedirectController = new ExampleRedirectController();
            RedirectToRouteResult actionResult = (RedirectToRouteResult)exampleRedirectController.Redirec3();
            string action = actionResult.RouteValues["action"].ToString();
            string controller = actionResult.RouteValues["controller"].ToString();
            Assert.IsTrue(action.Contains("Method1") && controller.Contains("Simple"));
        }
    }
}
