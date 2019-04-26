using ProjectContar.Domain.Contracts.App;
using ProjectContar.Domain.Entities;
using ProjectContar.Domain.Utils.Notifications;
using System;
using System.Collections.Generic;

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