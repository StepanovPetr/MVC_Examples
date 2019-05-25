using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_2;
using Services_2;
using System.Data.Entity;

namespace _3_ModelExample_3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Services_2.DbServises db = new Services_2.DbServises();
            return View(db.SelectAll());
        }


        public ActionResult Details(int id)
        {
            Services_2.DbServises db = new Services_2.DbServises();
            return View(db.FindElem(id));
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            Services_2.DbServises db = new Services_2.DbServises();
            return View(db.FindElem(id));
        }


        [HttpPost]
        public ActionResult Edit(Band band)
        {
            if (ModelState.IsValid)
            {
                Services_2.DbServises db = new Services_2.DbServises();
                if (db.EditElem(band))
                {
                    return View("Index", db.SelectAll());
                }


            }
            return View(band);
        }


        public ActionResult Delete(int id)
        {
            Services_2.DbServises db = new Services_2.DbServises();
            db.DeleteElem(id);
            return View("Index", db.SelectAll());
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Band band)
        {
            if (ModelState.IsValid)
            {
                Services_2.DbServises db = new Services_2.DbServises();
                if (db.AddElem(band))
                {
                    return View("Index", db.SelectAll());
                }
                else
                {
                    return JavaScript("Alert('Данная Группа уже сужествует')");
                }
            }
            return View(band);
        }

    }
}