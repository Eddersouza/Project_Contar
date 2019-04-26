using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Utils.Interfaces
{
    public interface EventNotificationServiceContract
    {
        bool HasNotifications { get; }
        bool HasErrors { get; }
        bool HasWarnings { get; }
        bool HasInformations { get; }

        IEnumerable Errors();

        IEnumerable Warnings();

        IEnumerable Informations();
    }
}
