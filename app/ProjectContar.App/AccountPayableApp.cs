using edrsys.EventNotification;
using edrsys.EventNotification.Levels;
using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Contracts.Repositories;
using ProjectContar.Domain.Entities;
using System;

namespace ProjectContar.App
{
    public class AccountPayableApp
        : EventNotificationServices, AccountPayableAppContract
    {
        /// <summary>
        /// Information to New Account Payable Added.
        /// </summary>
        public static EventNotificationDescription NewAccountPayableAdd =
            new EventNotificationDescription(
                "Conta Incluída com Sucesso.",
                new EventNotificationInformation());

        /// <summary>
        /// Instance of Accountable payable repository.
        /// </summary>
        private readonly AccountPayableRepositoryContract _accountPayableRepository;

        /// <summary>
        /// Create new Account Payable Repository.
        /// </summary>
        /// <param name="accountPayableRepository">Instance of Accountable payable repository.</param>
        public AccountPayableApp(
            AccountPayableRepositoryContract accountPayableRepository)
        {
            this._accountPayableRepository = accountPayableRepository;
        }

        public void Add(
            string name,
            DateTime? dueDate,
            decimal amount)
        {
            bool created = false;

            AccountPayable account = new AccountPayable(
                name,
                dueDate,
                amount);

            if (account.IsValid())
                created = this._accountPayableRepository.Create(account);

            if (created)
                account.EventNotification.Add(NewAccountPayableAdd);

            NotificationEntity = account;
        }
    }
}