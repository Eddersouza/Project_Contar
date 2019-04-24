using ProjectContar.Domain.Utils.Interfaces.Errors;
using ProjectContar.Domain.Utils.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectContar.Domain.Utils.Errors
{
    public class ErrorDescription : Description
    {
        public ILevel Level { get; }

        public ErrorDescription(
            string message, 
            ILevel level, 
            params string[] args)
            : base(message, args)
        {
            Level = level;
        }
    }
}
