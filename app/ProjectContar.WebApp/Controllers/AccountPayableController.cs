using edrsys.Utils.Extensions;
using ProjectContar.WebApp.ViewModels.AccountPayables;
using System;
using System.Web.Mvc;

namespace ProjectContar.WebApp.Controllers
{
    /// <summary>
    /// Controller to Account Payable.
    /// </summary>
    [RoutePrefix("contas-a-pagar")]
    public class AccountPayableController : Controller
    {
        /// <summary>
        /// Access Page to new Account Payable.
        /// </summary>
        /// <returns>Page view.</returns>
        [HttpGet]
        [Route("nova")]
        public ActionResult New()
        {
            AccountPayableNewPage view = new AccountPayableNewPage();
            return View(view);
        }

        /// <summary>
        /// Create new Account Payable.
        /// </summary>
        /// <param name="view">Object with data to create.</param>
        /// <returns>Page view Result.</returns>
        [HttpPost]
        [Route("nova")]
        public ActionResult New(AccountPayableNewPage view)
        {
            DateTime? date = view.Item.DueDate.ToNullableDate();
            decimal amount = view.Item.Amount.ToDecimal();
            return View(view);
        }
    }
}