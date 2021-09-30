using System.Linq;
using business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace uiweb.ViewComponents
{
    public class AuthorViewComponent:ViewComponent
    {
        private readonly IAuthorService _authorService;
        public AuthorViewComponent(IAuthorService authorService)
        {
            _authorService = authorService;
        }
         public IViewComponentResult Invoke(){



            return View(_authorService.GetAll().FirstOrDefault());
        }
    }
}