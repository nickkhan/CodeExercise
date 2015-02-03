
using ShawCodeExercise.Models;
using System.Collections.Generic;
namespace ShawCodeExerciseApp
{
    public static class StaticCache
    {
        private static List<VideoModel> videos = null;
        private static List<CategoryModel> categories = null;
        private static List<ShowModel> shows = null;
        public static void LoadStaticCache(){

            videos = InitVideos();
            categories = InitCategories();
            shows = InitShows();
        }
        

        public static List<VideoModel> Videos 
        {
            get { return videos; }
        }

        public static List<CategoryModel> Categories
        {
            get { return categories; }
        }

        public static List<ShowModel> Shows
        {
            get { return shows; }
        }

        private static List<ShowModel> InitShows()
        {
            var shows = new List<ShowModel>();

            var show1 = new ShowModel();
            show1.ID = 1;
            show1.ShowName = "Rookie Blue";
            show1.ShowCategories = new List<CategoryModel>();
            show1.ShowCategories.Add(Categories[0]);
            show1.ShowCategories.Add(Categories[1]);
           
            show1.BackgroundImagePath = string.Empty;

            var show2 = new ShowModel();
            show2.ID = 2;
            show2.ShowName = "Sleepy Hollow";
            show2.ShowCategories = new List<CategoryModel>();
            show2.ShowCategories.Add(Categories[0]);
            show2.ShowCategories.Add(Categories[2]);

            show2.BackgroundImagePath = string.Empty;


            shows.Add(show1);
            shows.Add(show2);

            return shows;
        }

        private static List<VideoModel> InitVideos()
        {
            var videos = new List<VideoModel>();

            var video1 = new VideoModel();
            video1.ID = 1;
            video1.SeasonNo = "S01";
            video1.EpisodeNo = "E01";
            video1.Title = "video 1 title";
            video1.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Hic ambiguo ludimur. Que Manilium, ab iisque M. Efficiens dici potest. Falli igitur possumus. Quae sequuntur igitur? Duo Reges: constructio interrete.";
            video1.ThumbnailPath = string.Empty;
            video1.IsLocked = false;
            videos.Add(video1);

            var video2 = new VideoModel();
            video2.ID = 2;
            video2.SeasonNo = "S01";
            video2.EpisodeNo = "E02";
            video2.Title = "video 2 title";
            video2.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Hic ambiguo ludimur. Que Manilium, ab iisque M. Efficiens dici potest. Falli igitur possumus. Quae sequuntur igitur? Duo Reges: constructio interrete.";
            video2.ThumbnailPath = string.Empty;
            video2.IsLocked = false;
            videos.Add(video2);

            var video3 = new VideoModel();
            video3.ID = 3;
            video3.SeasonNo = "S01";
            video3.EpisodeNo = "E03";
            video3.Title = "video 3 title";
            video3.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Hic ambiguo ludimur. Que Manilium, ab iisque M. Efficiens dici potest. Falli igitur possumus. Quae sequuntur igitur? Duo Reges: constructio interrete.";
            video3.ThumbnailPath = string.Empty;
            video3.IsLocked = false;
            videos.Add(video3);

            var video4 = new VideoModel();
            video4.ID = 4;
            video4.SeasonNo = "S01";
            video4.EpisodeNo = "E04";
            video4.Title = "video 4 title";
            video4.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Hic ambiguo ludimur. Que Manilium, ab iisque M. Efficiens dici potest. Falli igitur possumus. Quae sequuntur igitur? Duo Reges: constructio interrete.";
            video4.ThumbnailPath = string.Empty;
            video4.IsLocked = false;
            videos.Add(video4);

            var video5 = new VideoModel();
            video5.ID = 5;
            video5.SeasonNo = "S01";
            video5.EpisodeNo = "E05";
            video5.Title = "video 5 title";
            video5.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Hic ambiguo ludimur. Que Manilium, ab iisque M. Efficiens dici potest. Falli igitur possumus. Quae sequuntur igitur? Duo Reges: constructio interrete.";
            video5.ThumbnailPath = string.Empty;
            video5.IsLocked = false;
            videos.Add(video5);

            return videos;

        }              

        private static List<CategoryModel> InitCategories()
        {
            var categories = new List<CategoryModel>();

            var category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.FULLEPISODES;
            category.ShowID = 1;
            category.CategoryName = CategoryModel.CategoryEnum.FULLEPISODES.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[0],
                Videos[1]
            };

            categories.Add(category);

            category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.ETCANADASEGMENTS;
            category.ShowID = 1;
            category.CategoryName = CategoryModel.CategoryEnum.ETCANADASEGMENTS.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[2],
                Videos[3]
            };
            categories.Add(category);

            category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.FULLEPISODES;
            category.ShowID = 2;
            category.CategoryName = CategoryModel.CategoryEnum.FULLEPISODES.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[1],
                Videos[4]
            };
            categories.Add(category);

            category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.RBTV;
            category.ShowID = 2;
            category.CategoryName = CategoryModel.CategoryEnum.RBTV.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[0],
                Videos[3]
            };
            categories.Add(category);

            category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.WEBISODES;
            category.ShowID = 1;
            category.CategoryName = CategoryModel.CategoryEnum.WEBISODES.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[0],
                Videos[2]
            };
            categories.Add(category);

            category = new CategoryModel();
            category.ID = (int)CategoryModel.CategoryEnum.CLIPS;
            category.ShowID = 1;
            category.CategoryName = CategoryModel.CategoryEnum.CLIPS.ToString();
            category.ShowCategoryVideos = new List<VideoModel>(){
                Videos[3],
                Videos[4]
            };
            categories.Add(category);

            return categories;

        }
    }
}