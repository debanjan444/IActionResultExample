using Microsoft.AspNetCore.Mvc;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("book")]
        public IActionResult Book()
        {
           Boolean flag1 = Request.Query.ContainsKey("isloggedin") && Request.Query["isLoggedin"] == "true";
            Boolean flag2 = Request.Query.ContainsKey("bookid") && Convert.ToInt32(Request.Query["bookid"]) > 1 && Convert.ToInt32(Request.Query["bookid"]) < 100;


            if (flag1 && flag2)
            {
               return File("/schdule.pdf", "application/pdf");   
            }
            else
            {
                Response.StatusCode = 400;

                return Content("not valid querystring.", "text/plain");
            }
        }

    }
}
