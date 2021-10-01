
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
        private readonly ICommentService _commentService;

        public HomeController(IBlogService blog, IMusicService musicService,ICommentService commentService)
        {
            _blogService = blog;
            _musicService = musicService;
            _commentService = commentService;

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
                return RedirectToAction("error", "home");
            }
            var model = _blogService.GetById((int)id);
            if (model == null)
            {
                return RedirectToAction("error", "home");
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
                return RedirectToAction("error", "home");
            }

            ICollection<entity.Blog> model = _blogService.GetTagBlog((int)id);
            if (model == null)
            {
                return RedirectToAction("error", "home");
            }
            return View(model);
        }


        public IActionResult Search(string q)
        {

            if (q == null)
            {
                return RedirectToAction("error", "home");
            }
            var model = _blogService.GetSearch(q);
            if (model == null)
            {
                return RedirectToAction("error", "home");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult CreateMessage(string name, string message,int id)
        {
            Console.WriteLine(name);
            Console.WriteLine(message);
            var model=new entity.Comment();
            model.avatar="";
            model.date=DateTime.Now;
            model.hidden=false;
            model.username=name;
            model.message=message;
            model.Blogid=id;
            _commentService.Insert(model);
            return RedirectToAction("blog","home",new {id=id});
        }


    }
}
