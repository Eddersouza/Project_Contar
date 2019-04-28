using edrsys.EventNotification;
using edrsys.EventNotification.Levels;
using ProjectContar.Domain.Contracts.App;
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

        public void Add(
            string name,
            DateTime? dueDate,
            decimal amount)
        {
            AccountPayable account = new AccountPayable(
                name,
                dueDate,
                amount);

            if (account.IsValid())
                account.EventNotification.Add(NewAccountPayableAdd);

            NotificationEntity = account;
        }
    }
}