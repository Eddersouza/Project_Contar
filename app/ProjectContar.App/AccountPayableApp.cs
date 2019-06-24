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
            {
                this._accountPayableRepository.Create(account);
                created = this._accountPayableRepository.SaveChanges();
            }

            if (created)
                account.EventNotification.Add(NewAccountPayableAdd);

            NotificationEntity = account;
        }

        public AccountPayable Get(
            string name,
            DateTime? dueDate)
        {
            AccountPayable accountToSearch
                = new AccountPayable(name, dueDate);

            AccountPayable account = null;

            if (accountToSearch.IsValid())
                account = this._accountPayableRepository.Get(
                    new object[] { name, dueDate });

            if (account == null)
                accountToSearch.EventNotification.Add(new EventNotificationDescription(
                "Nenhuma conta {0}, com vencimento em {1}.",
                new EventNotificationWarning(), name, dueDate.HasValue ? dueDate.Value.ToShortDateString() : string.Empty));

            NotificationEntity = accountToSearch;
            
            return account;
        }
    }
}