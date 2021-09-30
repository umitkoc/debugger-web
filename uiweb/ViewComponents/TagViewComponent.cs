using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.ViewComponents
{
    public class TagViewComponent:ViewComponent
    {
        private readonly ITagService _service;
        public TagViewComponent(ITagService service)
        {
            _service = service;
        }
        public IViewComponentResult Invoke(){
            return View(_service.GetAll());
        }
    }
}