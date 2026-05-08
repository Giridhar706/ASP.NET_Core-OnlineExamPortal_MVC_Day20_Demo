using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace OnlineExamPortal.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var sessionValue =
                context.HttpContext.Session.GetString("StudentName");

            if (string.IsNullOrEmpty(sessionValue))
            {
                context.Result =
                    new RedirectToActionResult("Login", "Account", null);
            }
        }
    }
}