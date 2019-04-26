using ProjectContar.Domain.Utils.Notifications;
using System.Collections.Generic;

namespace ProjectContar.Domain.Utils.Interfaces
{
    public interface EventNotificationBaseContract
    {
        bool HasNotifications { get; }
        IList<object> List { get; }

        void Add(EventNotificationDescriptionBase error);

        bool Includes(EventNotificationDescriptionBase error);
    }
}