using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.ViewComponents
{
    public class AboutViewComponent:ViewComponent
    {
        private readonly IAboutService _aboutService;
        public AboutViewComponent(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
           public IViewComponentResult Invoke(){

            return View(_aboutService.GetAll());
        }
    }
}