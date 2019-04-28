using System.Web.Mvc;

namespace ProjectContar.WebApp.Controllers
{
    /// <summary>
    /// Controller to Home.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Home Index page.
        /// </summary>
        /// <returns>View Page result.</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}