using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShawCodeExercise.Models
{
    public class CategoryModel
    {
        public int ID { get; set; }
        public enum CategoryEnum
        {
            FULLEPISODES,
            WEBISODES,
            CLIPS,
            RBTV,
            ETCANADASEGMENTS
        };
        public int ShowID { get; set; }
        public string CategoryName { get; set; }

        public List<VideoModel> ShowCategoryVideos { get; set; }
    }
}
