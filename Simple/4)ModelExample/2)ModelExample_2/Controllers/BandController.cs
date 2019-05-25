using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Services_1;
using Model_1;

namespace _2_ModelExample_2.Controllers
{
    public class BandController : Controller
    {
        // GET: Band
        public ActionResult Index()
        {


            DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));

            //Передача данных в модель 
            return View(db.SelectAll());
        }

        public ActionResult Details(String id)
        {
            DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));
            return View(db.FindElem(id));
        }


        public ActionResult Delete(String id)
        {
            DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));
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
                DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));
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

        [HttpGet]
        public ActionResult Edit(String id)
        {

            DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));
            return View(db.FindElem(id));

        }


        [HttpPost]
        public ActionResult Edit(Band band)
        {
            if (ModelState.IsValid)
            {
                DBServices db = new DBServices(Server.MapPath("~/App_Data/List.dat"));
                if (db.EditElem(band))
                {
                    return View("Index", db.SelectAll());
                }


            }
            return View(band);
        }



    }   
}