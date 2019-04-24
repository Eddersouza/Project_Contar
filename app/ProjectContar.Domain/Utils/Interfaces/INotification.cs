using ProjectContar.Domain.Utils.Notifications;
using System.Collections.Generic;

namespace ProjectContar.Domain.Utils.Interfaces
{
    public interface INotification
    {
        bool HasNotifications { get; }
        IList<object> List { get; }

        void Add(Description error);

        bool Includes(Description error);
    }
}