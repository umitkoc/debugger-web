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
        [HttpGet]
        public IActionResult Comments()
        {


            return View(_commentService.GetAll());
        }
        public IActionResult Blogs()
        {


            return View(_blogService.GetBlogs());
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
        [HttpPost]
        public IActionResult Comments(int? id,string url){
            if(id==null){
                 return RedirectToAction("error", "home");
            }
            var model=_commentService.GetById((int)id);
            
            if(model==null){
             return RedirectToAction("error", "home");
            }
            model.avatar=url;
            _commentService.Update(model);
            return RedirectToAction("comments","admin");
        }

        public IActionResult HiddenComments(int? id){
            if(id==null){
                 return RedirectToAction("error", "home");
            }
            var model=_commentService.GetById((int)id);
            
            if(model==null){
             return RedirectToAction("error", "home");
            }
            model.hidden=!model.hidden;
            _commentService.Update(model);
            return RedirectToAction("comments","admin");
        }
    }
}