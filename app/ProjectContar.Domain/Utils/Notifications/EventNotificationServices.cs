using ProjectContar.Domain.Entities;
using ProjectContar.Domain.Utils.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectContar.Domain.Utils.Notifications
{
    public abstract class EventNotificationServices : EventNotificationServiceContract
    {
        protected EventNotificationEntity NotificationEntity;

        public bool HasNotifications => NotificationEntity != null && NotificationEntity.EventNotification.HasNotifications;
        public bool HasErrors => NotificationEntity != null && NotificationEntity.EventNotification.HasErrors;
        public bool HasWarnings => NotificationEntity != null && NotificationEntity.EventNotification.HasWarnings;
        public bool HasInformations => NotificationEntity != null && NotificationEntity.EventNotification.HasInformations;

        public IEnumerable Errors()
        {
            return NotificationEntity?.EventNotification.Errors;
        }

        public IEnumerable Warnings()
        {
            return NotificationEntity?.EventNotification.Warnings;
        }

        public IEnumerable Informations()
        {
            return NotificationEntity?.EventNotification.Informations;
        }
    }
}
