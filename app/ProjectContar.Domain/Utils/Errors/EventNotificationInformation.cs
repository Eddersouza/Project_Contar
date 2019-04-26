using ProjectContar.Domain.Utils.Interfaces.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Utils.Errors
{
    public class EventNotificationInformation : EventNotificationLevel
    {
        public EventNotificationInformation(string description = "Information")
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
