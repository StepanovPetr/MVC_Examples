using ControllerExample.Controllers;
using NUnit.Framework;
using System.Web;


namespace NutiTestsControllerExample
{
    [TestFixture]
    public class UnitTestControllerExample
    {
        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void TestMethod1()
        {
            MyFirstController myFirstController = new MyFirstController();
            Assert.IsTrue(myFirstController.Method1().Contains("Method1"));
        }

        [Test]
        public void TestMethod2()
        {
            MyFirstController myFirstController = new MyFirstController();
            Assert.IsTrue(myFirstController.Method2().Contains("Method2"));
        }

        [Test]
        public void TestMethod3()
        {
            MyFirstController myFirstController = new MyFirstController();
            Assert.IsTrue(myFirstController.Method3().Contains("Method3"));
        }

        [Test]
        public void TestIndex()
        {
            MyFirstController myFirstController = new MyFirstController();
            Assert.IsTrue(myFirstController.Index().Contains("Hello World"));
        }
    }
}
