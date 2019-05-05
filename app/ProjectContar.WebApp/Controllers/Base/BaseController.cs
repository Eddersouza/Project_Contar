using ProjectContar.WebApp.ViewModels.Shared;
using System.Web.Mvc;

namespace ProjectContar.WebApp.Controllers.Base
{
    /// <summary>
    /// Base Controller;
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// Add message to view.
        /// </summary>
        /// <param name="message">Message result.</param>
        public void AddMessage(MessageView message)
        {
            TempData["Messages_Contar"] = message;
        }
    }
}