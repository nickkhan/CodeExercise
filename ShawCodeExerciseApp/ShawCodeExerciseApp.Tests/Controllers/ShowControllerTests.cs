using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShawCodeExerciseApp.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;
using System.Web.Http.Hosting;

namespace ShawCodeExerciseApp.Controllers.Tests
{
    [TestClass()]
    public class ShowControllerTests
    {
        [TestMethod()]
        public void GetShowDataIDExistsShouldPassTest()
        {

            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/GetShowData");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show"} });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var response = sc.GetShowData(1);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);

            response = sc.GetShowData(100);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.NotFound);
        }

        [TestMethod()]
        public void GetShowDataIDDoesNotExistsShouldFailTest()
        {

            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/GetShowData");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var response = sc.GetShowData(100);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.NotFound);
        }

        [TestMethod()]
        public void CreateShowShouldPassTest()
        {
            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/CreateShow");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var show = new ShawCodeExercise.Models.ShowModel();
            show.ID = 10;
            show.ShowName = "the muppets";
            show.ShowCategories = StaticCache.Categories;
            show.BackgroundImagePath = string.Empty;

            var response = sc.CreateShow(show);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Created);
        }

        [TestMethod()]
        public void CreateShowDuplicateTest()
        {
            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/CreateShow");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var show = new ShawCodeExercise.Models.ShowModel();
            show.ID = 1;
            show.ShowName = "Rookie Blue";
            show.ShowCategories = StaticCache.Categories;
            show.BackgroundImagePath = string.Empty;

            var response = sc.CreateShow(show);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.Conflict);
        }
         [TestMethod()]
        public void CreateShowTestShouldFailTest()
        {
            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/CreateShow");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            ShawCodeExercise.Models.ShowModel show = null;

            var response = sc.CreateShow(show);
            Assert.AreEqual(response.StatusCode, HttpStatusCode.NotAcceptable);
        }

        [TestMethod()]
        public void DeleteShowShouldPassTest()
        {
            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/DeleteShow");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var response = sc.DeleteShow(1);
            
            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }

         [TestMethod()]
        public void DeleteShowShouldFailTest()
        {
            StaticCache.LoadStaticCache();
            ShowController sc = new ShowController();

            var config = new HttpConfiguration();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:22121/api/show/DeleteShow");
            var route = config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
            var routeData = new HttpRouteData(route, new HttpRouteValueDictionary { { "controller", "show" } });

            sc.ControllerContext = new HttpControllerContext(config, routeData, request);
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            var response = sc.DeleteShow(10000);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.NotFound);
        }
    }
}
