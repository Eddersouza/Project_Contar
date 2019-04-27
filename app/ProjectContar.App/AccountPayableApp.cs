using edrsys.EventNotification;
using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Entities;
using System;

namespace ProjectContar.App
{
    public class AccountPayableApp
        : EventNotificationServices, AccountPayableAppContract
    {
        public void Add(
            string name,
            DateTime? dueDate,
            decimal amount)
        {
            AccountPayable account = new AccountPayable(
                name,
                dueDate.Value,
                amount);

            NotificationEntity = account;
        }
    }
}