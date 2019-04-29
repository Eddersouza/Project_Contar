using System.Web.Mvc;

namespace ProjectContar.WebApp.Controllers
{
    /// <summary>
    /// Controller to Account Payable.
    /// </summary>
    [RoutePrefix("contas-a-pagar")]
    public class AccountPayableController : Controller
    {
        [HttpGet]
        [Route("nova")]
        public ActionResult New()
        {
            return View();
        }
    }
}