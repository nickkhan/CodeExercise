using ShawCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShawCodeExerciseApp.Controllers
{
    public class ShowController : ApiController
    {
        static List<ShowModel> Shows = InitShows();

        private static List<ShowModel> InitShows()
        {
            var shows = new List<ShowModel>();

            var show1 = new ShowModel();
            show1.ID = 1;
            show1.ShowName = "Rookie Blue";
            show1.ShowCategories = new List<CategoryModel>() 
            { 
                new CategoryModel
                    {
                        CategoryName=CategoryModel.CategoryEnum.FULLEPISODES,ShowCategoryVideos= new List<VideoModel>{
                        new VideoModel(){ID=1,Title="Title 1",Description="Title 1 description",SeasonNo="S01",EpisodeNo="E01"},
                        new VideoModel(){ID=2,Title="Title 2",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E02"},
                        }
                    },
                new CategoryModel
                    {
                        CategoryName=CategoryModel.CategoryEnum.WEBISODES,ShowCategoryVideos= new List<VideoModel>{
                        new VideoModel(){ID=1,Title="Title 1",Description="Title 1 description",SeasonNo="S01",EpisodeNo="E01"},
                        new VideoModel(){ID=2,Title="Title 2",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E02"},
                        new VideoModel(){ID=3,Title="Title 3",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E03"},
                        new VideoModel(){ID=4,Title="Title 4",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E04"}}
                    } 
            };
            show1.BackgroundImagePath = string.Empty;

            var show2 = new ShowModel();
            show2.ID = 2;
            show2.ShowName = "Sleepy Hollow";
            show2.ShowCategories = new List<CategoryModel>() 
            { 
                new CategoryModel
                    {
                        CategoryName=CategoryModel.CategoryEnum.FULLEPISODES,ShowCategoryVideos= new List<VideoModel>{
                        new VideoModel(){ID=1,Title="Title 1",Description="Title 1 description",SeasonNo="S01",EpisodeNo="E01"},
                        new VideoModel(){ID=2,Title="Title 2",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E02"},
                        new VideoModel(){ID=3,Title="Title 3",Description="Title 3 description",SeasonNo="S01",EpisodeNo="E03"}
                        }
                    },
                new CategoryModel
                    {
                        CategoryName=CategoryModel.CategoryEnum.WEBISODES,ShowCategoryVideos= new List<VideoModel>{
                        new VideoModel(){ID=1,Title="Title 1",Description="Title 1 description",SeasonNo="S01",EpisodeNo="E01"},
                        new VideoModel(){ID=2,Title="Title 2",Description="Title 2 description",SeasonNo="S01",EpisodeNo="E02"},
                        new VideoModel(){ID=3,Title="Title 3",Description="Title 3 description",SeasonNo="S01",EpisodeNo="E03"}}                        
                    } 
            };
            show2.BackgroundImagePath = string.Empty;


            shows.Add(show1);
            shows.Add(show2);

            return shows;
        }

        [HttpGet]
        public IEnumerable<ShowModel> Get()
        {
            return Shows;
        }

        [HttpGet]
        public ShowModel GetShowData(int ID)
        {
            return Shows.Where(show => show.ID == ID).FirstOrDefault();            
        }

        [HttpPost]
        public void CreateShow([FromBody]ShowModel show)
        {
            if (show != null)
            {
                Shows.Add(show);
            }
        }

        [HttpPost]
        public void DeleteShow([FromBody]int ID)
        {
            Shows.Remove(Shows.Single(e => e.ID == ID));
        }
    }
}
