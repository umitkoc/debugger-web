using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.Controllers
{
    public class AdminController : Controller
    {
        ICommentService _commentService;
        IAboutService _aboutService;
        ISocialService _socialService;
        IBlogService _blogService;
        ITagService _tagService;

        public AdminController(ICommentService commentService, IBlogService blog, ISocialService socialService, ITagService tagService, IAboutService aboutService)
        {
            _commentService = commentService;
            _aboutService = aboutService;
            _blogService = blog;
            _tagService = tagService;
            _socialService = socialService;
        }

        public IActionResult Home()
        {

            return View();
        }
        public IActionResult Comments()
        {


            return View();
        }
        public IActionResult Blogs()
        {


            return View();
        }

        public IActionResult Tags()
        {


            return View();
        }
        public IActionResult Socials()
        {


            return View();
        }

        public IActionResult Musics()
        {


            return View();
        }

          public IActionResult About()
        {


            return View();
        }

          public IActionResult Profil()
        {


            return View();
        }
    }
}