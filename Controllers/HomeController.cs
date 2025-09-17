using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PhotoAlbum.Models;

namespace PhotoAlbum.Controllers
{
    //This is the home controller class
    public class HomeController : Controller
    {
        //Constructor
        public HomeController() { }

        //Action method /Index
        public IActionResult Index()
        {
            return View();
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
    }
}
