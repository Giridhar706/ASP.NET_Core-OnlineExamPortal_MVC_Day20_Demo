using Microsoft.AspNetCore.Mvc;

namespace OnlineExamPortal.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            // Read cookie if exists
            ViewBag.Theme =
                Request.Cookies["ThemePreference"];

            return View();
        }

        [HttpPost]
        public IActionResult Login(
            string studentName,
            string course,
            string theme)
        {
            // Session Storage
            HttpContext.Session.SetString(
                "StudentName",
                studentName);

            HttpContext.Session.SetString(
                "Course",
                course);

            // Cookie Storage
            CookieOptions options = new CookieOptions();

            options.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Append(
                "ThemePreference",
                theme,
                options);

            return RedirectToAction("Index", "Dashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}
