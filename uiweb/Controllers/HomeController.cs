
using System;
using System.Collections.Generic;
using System.Linq;
using business.Abstract;
using Microsoft.AspNetCore.Mvc;
using uiweb.Models;

namespace uiweb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IMusicService _musicService;

        public HomeController(IBlogService blog, IMusicService musicService)
        {
            _blogService = blog;
            _musicService = musicService;

        }
        public IActionResult Index()
        {

            ICollection<entity.Blog> model = _blogService.GetAll();



            return View(model);
        }
        public IActionResult Blog(int? id)
        {
            if (id == null)
            {
                  return RedirectToAction("error","home");
            }
            var model = _blogService.GetById((int)id);
            if (model == null)
            {
                  return RedirectToAction("error","home");
            }
            return View(model);
        }


        public IActionResult Music()
        {

            var model = _musicService.GetAll();
            return View(model);
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Tagsearch(int? id)
        {
            if (id == null)
            {
               return RedirectToAction("error","home");
            }

            ICollection<entity.Blog> model = _blogService.GetTagBlog((int)id);
            if (model == null)
            {
                return RedirectToAction("error","home");
            }
            return View(model);
        }


        public IActionResult Search(string q)
        {

            if (q == null)
            {
                  return RedirectToAction("error","home");
            }
            var model = _blogService.GetSearch(q);
            if (model == null)
            {
                 return RedirectToAction("error","home");
            }

            return View(model);
        }


    }
}
