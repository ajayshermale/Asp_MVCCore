using Microsoft.AspNetCore.Mvc;

namespace Asp_MVCCore.Components
{
    public class CommentViewComponent:ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int ids, string name)
        {
            List<string > commente = new List<string> { "good" , "new" ,"oh", "ajay"};

            if(commente.Contains(name))
            {
                return View("~/Views/Components/_comment.cshtml",commente);
            }

            return View("~/Views/Home/Index.cshtml");
            //use IviewCOmponent result
        }
    }
}
