using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using Services_2;
using Model_2;
using System.Data.Entity;
namespace ApiExample.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HomeController : ApiController
    {

        //получение всех значений из БД
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {
            var db = new DbServises ();

            List<Band> bands =  db.SelectAll().ToList<Band>();
            foreach (Band b in bands)
            {
                b.Albums.Count();
                b.Musicants.Count();
            }                    
           return Request.CreateResponse(HttpStatusCode.OK, bands);         
        }

        //получение из БД значения по id 
        [AllowAnonymous]
        public HttpResponseMessage Get(int id)
        {
            var db = new DbServises();

            Band bands = db.FindElem(id);

            bands.Albums.Count();
            bands.Musicants.Count();
            
            return Request.CreateResponse(HttpStatusCode.OK, bands);
        }
        // добавления значения в БД 
        public HttpResponseMessage Post(object Elem)
        {
            
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        //удаление значения из БД значения по id 
        public HttpResponseMessage Delete(int id)
        {

            return Request.CreateResponse(HttpStatusCode.OK);
        }
        //изменеия значения из БД значения по id 
        public HttpResponseMessage Put(object Elem)
        {

            return Request.CreateResponse(HttpStatusCode.OK);
        }


    }
}
