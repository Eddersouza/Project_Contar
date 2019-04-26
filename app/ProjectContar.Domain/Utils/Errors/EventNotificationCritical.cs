using ProjectContar.Domain.Utils.Interfaces.Errors;

namespace ProjectContar.Domain.Utils.Errors
{
    public class EventNotificationCritical : EventNotificationLevel
    {
        public EventNotificationCritical(string description = "Critical")
        {
            Description = description;
        }

        public string Description { get; }

        public override string ToString()
        {
            return Description;
        }
    }
}