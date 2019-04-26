using ProjectContar.Domain.Utils.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Entities
{
    public class EventNotificationEntity
    {
        public EventNotification EventNotification { get; } = new EventNotification();

        public virtual void Validate() { }

        protected void Fail(
            bool condition, 
            EventNotificationDescription description)
        {
            if (condition)
                EventNotification.Add(description);
        }

        public bool IsValid()
        {
            return !EventNotification.HasErrors;
        }
        
        protected void IsInvalidName(string s, EventNotificationDescription error)
        {
            Fail(string.IsNullOrWhiteSpace(s), error);
        }        
    }
}
