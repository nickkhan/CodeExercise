using ShawCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

//200 OK: Success
//201 Created - Used on POST request when creating a new resource.
//304 Not Modified: no new data to return.
//400 Bad Request: Invalid Request.
//401 Unauthorized: Authentication.
//403 Forbidden: Authorization
//404 Not Found – entity does not exist.
//406 Not Acceptable – bad params.
//409 Conflict - For POST / PUT requests if the resource already exists.
//500 Internal Server Error
//503 Service Unavailable
namespace ShawCodeExerciseApp.Controllers
{
    public class ShowController : ApiController
    {


        public IEnumerable<ShowModel> Index()
        {
            return StaticCache.Shows;
        }


        public HttpResponseMessage GetShowData(int id)
        {
            var findShow = StaticCache.Shows.Where(show => show.ID == id).FirstOrDefault();
            if (findShow == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Show not found");

            var response = Request.CreateResponse<ShowModel>(HttpStatusCode.OK, findShow);

            return response;             
        }

        [HttpPost]
        public HttpResponseMessage CreateShow(ShowModel show)
        {
            if (show == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Show entry is null");

            var showExists = StaticCache.Shows.Where(e => e.ShowName == show.ShowName).FirstOrDefault();

            if(showExists!=null)
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Show entry already exists");

            StaticCache.Shows.Add(show);

            var response = Request.CreateResponse<ShowModel>(HttpStatusCode.Created, show);

            return response; 
        }

        public HttpResponseMessage DeleteShow(int id)
        {
            var show = StaticCache.Shows.FirstOrDefault(e => e.ID == id);
            if(show == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Show entry not found");
                        
            StaticCache.Shows.Remove(show);
            var response = Request.CreateResponse<ShowModel>(HttpStatusCode.OK, show);

            return response; 
        }
    }
}
