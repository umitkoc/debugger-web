using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.ViewComponents
{
    public class SocialViewComponent:ViewComponent
    {

        private readonly ISocialService _socialService;
        public SocialViewComponent(ISocialService socialService)
        {
            _socialService = socialService;
        }


           public IViewComponentResult Invoke(){



            return View(_socialService.GetAll());
        }
    }
}