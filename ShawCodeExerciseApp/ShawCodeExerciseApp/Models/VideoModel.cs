using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShawCodeExercise.Models
{
    public class VideoModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SeasonNo { get; set; }
        public string EpisodeNo { get; set; }
        public string ThumbnailPath { get; set; }
        public bool IsLocked { get; set; }
    }
}
