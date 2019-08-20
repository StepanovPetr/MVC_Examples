using System.Web.Mvc;
using NUnit.Framework;
using _3_FileDownload.Controllers;
namespace NUnitTestsFileExampleController
{
    [TestFixture]
    public class UnitTestsFileExampleController
    {
        [Test]
        public void TestMethod1()
        {
            FileExampleController fileExampleController = new FileExampleController();
            FilePathResult actionResult  = (FilePathResult)fileExampleController.Download1();
            Assert.IsTrue(actionResult.FileName.Contains(@"/Download/165.mp3"));
        }

        [Test]
        public void TestMethod2()
        {
            FileExampleController fileExampleController = new FileExampleController();
            FileContentResult actionResult = (FileContentResult)fileExampleController.Download2();
            Assert.IsTrue(actionResult.FileDownloadName.Contains(@"1.mp3")&& actionResult.FileContents.Length > 0);
        }

        [Test]
        public void TestMethod3()
        {
            FileExampleController fileExampleController = new FileExampleController();
            FileStreamResult actionResult = (FileStreamResult)fileExampleController.Download3();
            Assert.IsTrue(actionResult.FileDownloadName.Contains(@"1.mp3") && actionResult.FileStream !=null);
        }

        [TestCase("1.mp3")]
        [TestCase("2.mp3")]
        [TestCase("3.mp3")]
        public void DownloadFileByNamePositive(string fileName)
        {
            FileExampleController fileExampleController = new FileExampleController();
            FileContentResult actionResult = (FileContentResult)fileExampleController.DownloadFileByName(fileName);
            Assert.IsTrue(actionResult.FileDownloadName.Contains(fileName) && actionResult.FileContents.Length > 0);
        }

        [TestCase("1000.mp3")]
        [TestCase("2000.mp3")]
        [TestCase("3000.mp3")]
        [TestCase("4000.mp3")]
        [TestCase("5000.mp3")]
        [TestCase("6000.mp3")]
        public void DownloadFileByNameNegative(string fileName)
        {
            FileExampleController fileExampleController = new FileExampleController();
            ContentResult actionResult = (ContentResult)fileExampleController.DownloadFileByName(fileName);
            Assert.IsFalse(actionResult.Content.Contains(fileName));
        }
    }
}
