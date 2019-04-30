using edrsys.EventNotification.Contracts;
using System.Collections.Generic;

namespace ProjectContar.WebApp.ViewModels.Shared
{
    /// <summary>
    /// Represent Messages in View.
    /// </summary>
    public class MessageView
    {
        /// <summary>
        /// Create Message Object.
        /// </summary>
        public MessageView()
        {
            this.Errors = new List<string>();
            this.Information = new List<string>();
            this.Warnings = new List<string>();
        }

        /// <summary>
        /// Create Message Object.
        /// </summary>
        /// <param name="eventNotivications">Event Notifications.</param>
        public MessageView(
            EventNotificationServiceContract eventNotivications) : this()
        {
            foreach (var item in eventNotivications.Errors())
            {
                this.Errors.Add(item.ToString());
            }

            foreach (var item in eventNotivications.Informations())
            {
                this.Information.Add(item.ToString());
            }

            foreach (var item in eventNotivications.Warnings())
            {
                this.Warnings.Add(item.ToString());
            }
        }

        /// <summary>
        /// Errors list.
        /// </summary>
        public List<string> Errors { get; set; }

        /// <summary>
        /// Information list.
        /// </summary>
        public List<string> Information { get; set; }

        /// <summary>
        /// Warnings list.
        /// </summary>
        public List<string> Warnings { get; set; }
    }
}