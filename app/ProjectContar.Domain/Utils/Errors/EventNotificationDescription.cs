using ProjectContar.Domain.Utils.Interfaces.Errors;
using ProjectContar.Domain.Utils.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Utils.Errors
{
    public class EventNotificationDescription : EventNotificationDescriptionBase
    {
        public EventNotificationLevel Level { get; }

        public EventNotificationDescription(
            string message, 
            EventNotificationLevel level, 
            params string[] args)
            : base(message, args)
        {
            Level = level;
        }
    }
}
