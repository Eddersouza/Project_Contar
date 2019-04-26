using ProjectContar.Domain.Utils.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.Domain.Utils.Notifications
{
    public abstract class EventNotificationBase : EventNotificationBaseContract
    {
        public bool HasNotifications => List.Any();
        public IList<object> List { get; } = new List<object>();

        public void Add(EventNotificationDescriptionBase description)
        {
            List.Add(description);
        }

        public bool Includes(EventNotificationDescriptionBase error)
        {
            return List.Contains(error);
        }
    }
}