using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]     // root path
      public ActionResult Index()
      {
        return View();
      }

    }
}
