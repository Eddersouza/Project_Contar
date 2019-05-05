using edrsys.Utils.Extensions;
using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Entities;
using ProjectContar.WebApp.Controllers.Base;
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
    public class AccountPayableController : BaseController
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
            try
            {
                this._accountPayableApp.Add(
                    view.Item.Name,
                    view.Item.DueDate.ToNullableDate(),
                    view.Item.Amount.ToDecimal());

                this.AddMessage(new MessageView(this._accountPayableApp));

                if (this._accountPayableApp.HasInformations)
                    return RedirectToAction("View", new
                    {
                        name = view.Item.Name.Trim(),
                        dueDate = view.Item.DueDate.Replace('/', '-')
                    });
            }
            catch (Exception exception)
            {
                this.CreateErroMessageView();
            }

            return View(view);
        }

        /// <summary>
        /// Create message view.
        /// </summary>
        private void CreateErroMessageView()
        {
            MessageView message = new MessageView();
            message.Errors.Add("Ocorreu um erro ao executar a ação, tente novamente ou entre em contato com o administrador.");

            this.AddMessage(message);
        }

        /// <summary>
        /// Access Page to view Account Payable.
        /// </summary>
        /// <param name="name">Account Name.</param>
        /// <param name="dueDate">Account due date.</param>
        /// <returns>Page view.</returns>
        [HttpGet]
        [Route("{name}/vencimento/{dueDate}/visualizar")]
        public ActionResult View(
            string name,
            string dueDate)
        {
            AccountPayableNewPage view = new AccountPayableNewPage();

            try
            {
                AccountPayable account = this._accountPayableApp.Get(
                    name,
                    dueDate.ToNullableDate());

                view.Item = new AccountPayableItem(
                    account.Name,
                    account.DueDate.Value,
                    account.Amount);

                this.AddMessage(new MessageView(this._accountPayableApp));
            }
            catch (Exception exception)
            {
                this.CreateErroMessageView();
            }

            return View(view);
        }
    }
}