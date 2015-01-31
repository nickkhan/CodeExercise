using ShawCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShawCodeExerciseApp.Controllers
{
    public class VideoController : ApiController
    {
        static List<VideoModel> Videos = InitVideos();

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
            
            return videos;

        }
        [HttpPost]
        public void CreateVideo([FromBody]VideoModel video)
        {
            if (video != null)
            {
                Videos.Add(video);
            }
        }
    }
}
