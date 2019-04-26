using ProjectContar.Domain.Utils.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.Domain.Utils.Errors
{
    public class EventNotification : EventNotificationBase
    {
        public IList<EventNotificationDescription> Errors => List.Cast<EventNotificationDescription>().Where(x => x.Level is EventNotificationCritical).ToList();
        public bool HasErrors => List.Cast<EventNotificationDescription>().Any(x => x.Level is EventNotificationCritical);
        public bool HasInformations => List.Cast<EventNotificationDescription>().Any(x => x.Level is EventNotificationInformation);
        public bool HasWarnings => List.Cast<EventNotificationDescription>().Any(x => x.Level is EventNotificationWarning);
        public IList<EventNotificationDescription> Informations => List.Cast<EventNotificationDescription>().Where(x => x.Level is EventNotificationInformation).ToList();
        public IList<EventNotificationDescription> Warnings => List.Cast<EventNotificationDescription>().Where(x => x.Level is EventNotificationWarning).ToList();
    }
}