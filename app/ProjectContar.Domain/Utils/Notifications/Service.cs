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
    public abstract class Service : IServiceNotification
    {
        protected Entity NotificationEntity;

        public bool HasNotifications => NotificationEntity != null && NotificationEntity.Errors.HasNotifications;
        public bool HasErrors => NotificationEntity != null && NotificationEntity.Errors.HasErrors;
        public bool HasWarnings => NotificationEntity != null && NotificationEntity.Errors.HasWarnings;
        public bool HasInformations => NotificationEntity != null && NotificationEntity.Errors.HasInformations;

        public IEnumerable Errors()
        {
            return NotificationEntity?.Errors.Errors;
        }

        public IEnumerable Warnings()
        {
            return NotificationEntity?.Errors.Warnings;
        }

        public IEnumerable Informations()
        {
            return NotificationEntity?.Errors.Informations;
        }
    }
}
