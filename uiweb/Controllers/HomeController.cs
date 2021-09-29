
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using uiweb.Models;

namespace uiweb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }


        public IActionResult Music()
        {
            List<MusicModel> model = new List<MusicModel>(){
                new MusicModel{Title="title1",Image="http://placeimg.com/640/480/sports",Url="https://ia801508.us.archive.org/4/items/music_1_202109/music_1.mp3"},
                new MusicModel{Title="title2",Image="http://placeimg.com/640/480",Url="https://ia601501.us.archive.org/22/items/music_2_202109/music_2.mp3"}
            };

            return View(model);
        }


    }
}
