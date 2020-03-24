using System.Web.Mvc;

namespace Redirect.Controllers
{
    public class ExampleRedirectController : Controller
    {
        // GET: ExampleRedirect
        public ActionResult Index()
        {
            return View();
        }

        // Пример с перенаправлением на другой сайт
        public ActionResult Redirec1()
        {
            return Redirect("http://www.google.ru");
        }

        // Пример с перенаправлением на другой 
        // Action в рамках одного Controller.
        public ActionResult Redirec2()
        {
            return RedirectToAction("Index");
        }

        // Пример с перенаправлением на другой 
        // Action и другой  Controller.
        public ActionResult Redirec3()
        {
            return RedirectToAction(
                "Method1", 
                "Simple");
        }       
    }
}