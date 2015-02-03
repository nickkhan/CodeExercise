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
    public class CategoryController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage CreateCategory(CategoryModel category)
        {
            if (category == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Category entry is null");

            var show = StaticCache.Shows.Where(e => e.ID == category.ShowID).FirstOrDefault();

            if(show!=null)
            {
                if (StaticCache.Categories.Where(c => c.CategoryName == category.CategoryName).FirstOrDefault() != null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Category entry already exists for showid");
                }
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Showid does not exist");
            }                

            StaticCache.Categories.Add(category);

            var response = Request.CreateResponse<CategoryModel>(HttpStatusCode.Created, category);

            return response;            
        }
    }
}
