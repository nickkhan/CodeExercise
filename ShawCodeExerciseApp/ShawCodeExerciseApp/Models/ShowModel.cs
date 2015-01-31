using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShawCodeExercise.Models
{
    public class ShowModel
    {
        public int ID { get; set; }
        public String ShowName { get; set; }
        public List<CategoryModel> ShowCategories { get; set; }        

        public string BackgroundImagePath { get; set; }
    }
}
