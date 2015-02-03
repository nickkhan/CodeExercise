using ShawCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



/*
 * Use Fiddler or advanced rest client extension for chrome to test Web Api
 * 
*/

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
    public class VideoController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage CreateVideo(VideoModel video)
        {
            if (video == null )
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Video entry is null");

            if(StaticCache.Videos.Where(e=>e.ID == video.ID).FirstOrDefault()!=null)
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Video entry already exists");

            StaticCache.Videos.Add(video);
            var response = Request.CreateResponse<VideoModel>(HttpStatusCode.Created, video);
            
            return response;
        }
    }
}
