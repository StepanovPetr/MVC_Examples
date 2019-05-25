using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _8_ModelBinding.Models;

namespace _8_ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public string Method1(int id = 0, string name = "")
        {
            return string.Format("{0}  --  {1} ", id.ToString(), name);
        }


        public string Method2(People people)
        {
            return string.Format("{0}  --  {1} ", people.Id.ToString(), people.Name);
        }

        public string Method3(People people)
        {
            return string.Format("{0}  --  {1} ", people.Id.ToString(), people.Name);
        }

    }
}