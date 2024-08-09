using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit([Bind]Models.User model)
        {
            if (ModelState.IsValid)
            {
                ViewData["pass"] = true;
            }
            return View("Create", model);
        }
    }
}