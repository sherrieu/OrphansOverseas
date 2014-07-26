using System.Web.Mvc;
using OrphansOverSeas.Models;

namespace OrphansOverSeas.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new HelloWorldModel());
        }
    }
}