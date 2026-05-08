using Microsoft.AspNetCore.Mvc;
using OnlineExamPortal.Filters;

namespace OnlineExamPortal.Controllers
{
    [AuthFilter]
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(
            ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var studentName =
                HttpContext.Session.GetString("StudentName");

            var course =
                HttpContext.Session.GetString("Course");

            var theme =
                Request.Cookies["ThemePreference"];

            ViewBag.StudentName = studentName;
            ViewBag.Course = course;
            ViewBag.Theme = theme;

            _logger.LogInformation(
                $"Student Logged In: {studentName}");

            return View();
        }
    }
}