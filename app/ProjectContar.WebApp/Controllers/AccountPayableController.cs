using edrsys.Utils.Extensions;
using ProjectContar.Domain.Contracts.App;
using ProjectContar.WebApp.ViewModels.AccountPayables;
using ProjectContar.WebApp.ViewModels.Shared;
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
        /// Instance of Account Payable App.
        /// </summary>
        private readonly AccountPayableAppContract _accountPayableApp;

        /// <summary>
        /// Create new Controller to Account Payable.
        /// </summary>
        /// <param name="accountPayableApp">Instance of Account Payable App.</param>
        public AccountPayableController(
            AccountPayableAppContract accountPayableApp)
        {
            this._accountPayableApp = accountPayableApp;
        }

        /// <summary>
        /// Access Page to new Account Payable.
        /// </summary>
        /// <returns>Page view.</returns>
        [HttpGet]
        [Route("nova")]
        public ActionResult New()
        {
            AccountPayableNewPage view = new AccountPayableNewPage();
            view.Message = new MessageView();
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

            try
            {
                this._accountPayableApp.Add(
                    view.Item.Name,
                    view.Item.DueDate.ToNullableDate(),
                    view.Item.Amount.ToDecimal());

                view.Message = new MessageView(this._accountPayableApp);
            }
            catch (Exception)
            {
                view.Message = new MessageView();
                view.Message.Errors.Add("Ocorreu um erro ao executar a ação, tente novamente ou entre em contato com o administrador.");
            }

            return View(view);
        }
    }
}