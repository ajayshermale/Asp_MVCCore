using Asp_MVCCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_MVCCore.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Signup(RegisterViewModel model)
        {

            if (string.IsNullOrEmpty(model.Name))
                ModelState.AddModelError(string.Empty, "Name is required Ajay");
            if (string.IsNullOrEmpty(model.Email))
                ModelState.AddModelError(string.Empty, "email Ajay ");

            if (ModelState.IsValid)
            { }


            return View();
        }


    }
}
