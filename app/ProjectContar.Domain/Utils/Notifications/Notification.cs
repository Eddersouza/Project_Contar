using ProjectContar.Domain.Utils.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.Domain.Utils.Notifications
{
    public abstract class Notification : INotification
    {
        public bool HasNotifications => List.Any();
        public IList<object> List { get; } = new List<object>();

        public void Add(Description description)
        {
            List.Add(description);
        }

        public bool Includes(Description error)
        {
            return List.Contains(error);
        }
    }
}