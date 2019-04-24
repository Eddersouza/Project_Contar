using ProjectContar.Domain.Utils.Notifications;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.Domain.Utils.Errors
{
    public class Error : Notification
    {
        public IList<ErrorDescription> Errors => List.Cast<ErrorDescription>().Where(x => x.Level is Critical).ToList();
        public bool HasErrors => List.Cast<ErrorDescription>().Any(x => x.Level is Critical);
        public bool HasInformations => List.Cast<ErrorDescription>().Any(x => x.Level is Information);
        public bool HasWarnings => List.Cast<ErrorDescription>().Any(x => x.Level is Warning);
        public IList<ErrorDescription> Informations => List.Cast<ErrorDescription>().Where(x => x.Level is Information).ToList();
        public IList<ErrorDescription> Warnings => List.Cast<ErrorDescription>().Where(x => x.Level is Warning).ToList();
    }
}