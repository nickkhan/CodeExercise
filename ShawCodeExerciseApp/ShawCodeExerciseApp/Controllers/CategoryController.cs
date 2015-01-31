using ShawCodeExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShawCodeExerciseApp.Controllers
{
    public class CategoryController : ApiController
    {
        static List<CategoryModel> Categories = InitCategories();

        private static List<CategoryModel> InitCategories()
        {
            var categories = new List<CategoryModel>();

            var category = new CategoryModel();
            category.ID = 1;
            category.CategoryName = CategoryModel.CategoryEnum.FULLEPISODES;
            categories.Add(category);

            category.ID = 2;
            category.CategoryName = CategoryModel.CategoryEnum.ETCANADASEGMENTS;
            categories.Add(category);

            category.ID = 3;
            category.CategoryName = CategoryModel.CategoryEnum.FULLEPISODES;
            categories.Add(category);

            category.ID = 4;
            category.CategoryName = CategoryModel.CategoryEnum.RBTV;
            categories.Add(category);

            category.ID = 5;
            category.CategoryName = CategoryModel.CategoryEnum.WEBISODES;
            categories.Add(category);

            category.ID = 6;
            category.CategoryName = CategoryModel.CategoryEnum.CLIPS;
            categories.Add(category);

            return categories;

        }
        [HttpPost]
        public void CreateCategory([FromBody]CategoryModel category)
        {
            if (category != null)
            {
                Categories.Add(category);
            }
        }
    }
}
