using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Services_2;

namespace ApiExample.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HomeController : ApiController
    {
        // Получение всех значений из БД.
        [AllowAnonymous]
        public HttpResponseMessage Get()
        {
            var db = new DbServises();

            var bands = db.SelectAll().ToList();
            foreach (var b in bands)
            {
                b.Albums.Count();
                b.Musicants.Count();
            }

            return Request.CreateResponse(HttpStatusCode.OK, bands);
        }

        // Получение из БД по id. 
        [AllowAnonymous]
        public HttpResponseMessage Get(int id)
        {
            var db = new DbServises();

            var bands = db.FindElem(id);

            bands.Albums.Count();
            bands.Musicants.Count();

            return Request.CreateResponse(HttpStatusCode.OK, bands);
        }

        // Добавления значения в БД. 
        public HttpResponseMessage Post(object elem)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // Удаление значения из БД по id. 
        public HttpResponseMessage Delete(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // Изменение значения из БД по id. 
        public HttpResponseMessage Put(object elem)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
