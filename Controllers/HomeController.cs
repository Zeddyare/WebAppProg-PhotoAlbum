using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbum.Models;

namespace PhotoAlbum.Controllers
{
    //This is the home controller class
    public class HomeController : Controller
    {
        //Constructor
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        //Action method /Index
        public IActionResult Index()
        {
            //Long way to create a list of photos
            List<Photo> photoList = new List<Photo>();
            Photo photo1 = new Photo();
            photo1.PhotoId = 1;
            photo1.Title = "Conway";
            photo1.Description = "My cat";
            photo1.Filename = "Connie.jpg";
            photo1.CreateDate = DateTime.Now;
            photo1.CategoryId = 2;

            photoList.Add(photo1);

            //Short way to create a list of photos
            var photos = new List<Photo>
            {
                new Photo
            {
                PhotoId = 2,
                Title = "Sparky",
                Description = "My dog",
                Filename = "Sparky.jpg",
                CreateDate = DateTime.Now,
                CategoryId = 2
            },

                new Photo
                {
                    PhotoId = 3,
                    Title = "Bubbles",
                    Description = "My fish",
                    Filename = "Bubbles.jpg",
                    CreateDate = new DateTime(2025, 09, 20),
                    CategoryId = 2
                }
            };

            _logger.Log(LogLevel.Information, "Number of Photos: " + photos.Count);
                
           
            return View(photoList);
        }

        //Action method /Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        //First action method
        public IActionResult Hello() 
        {
            return View();
        }

        public void Details(int id)
        {
            var Photo = new Photo {PhotoId = id};

        }
    }
}
