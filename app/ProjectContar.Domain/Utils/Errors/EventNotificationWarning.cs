using ProjectContar.Domain.Utils.Interfaces.Errors;

namespace ProjectContar.Domain.Utils.Errors
{
    public class EventNotificationWarning : EventNotificationLevel
    {
        public EventNotificationWarning(string description = "Warning")
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