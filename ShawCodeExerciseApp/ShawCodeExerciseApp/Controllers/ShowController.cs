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

 
        public ShowModel GetShowData(int id)
        {
            return StaticCache.Shows.Where(show => show.ID == id).FirstOrDefault();            
        }

        [HttpPost]
        public void CreateShow(ShowModel show)
        {
            if (show != null)
            {
                StaticCache.Shows.Add(show);
            }
        }

        public void DeleteShow(int id)
        {
            var show = StaticCache.Shows.FirstOrDefault(e => e.ID == id);
            if (show != null)
            {
                StaticCache.Shows.Remove(show);
            }
        }
    }
}
