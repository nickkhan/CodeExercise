using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShawCodeExerciseApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using System.Net.Http;
using System.Web.Http.Hosting;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Net;


namespace ShawCodeExerciseApp.Controllers.Tests
{
    [TestClass()]
    public class CategoryControllerTests
    {
        [TestMethod()]

        public void CreateCategoryShouldPassTest()
        {
            StaticCache.LoadStaticCache();
            VideoController vc = new VideoController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/category/CreateCategory");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "category" } });

            vc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            ShawCodeExercise.Models.VideoModel video = new ShawCodeExercise.Models.VideoModel()
            {
                ID = 6,
                Title = "Mock title",
                Description = "Mock Description",
                SeasonNo = "S012",
                EpisodeNo = "E01",
                IsLocked = false,
            };

            var response = vc.CreateVideo(video);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
        }
    }
}
