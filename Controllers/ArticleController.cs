using Microsoft.AspNetCore.Mvc;

namespace Asp_MVCCore.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add( int a , int b )
        {
            int x = a;
            int y = b;
            int o = x + y;


            return View(o);
        }
    }
    
}
