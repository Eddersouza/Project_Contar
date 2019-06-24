using edrsys.EventNotification.Contracts;
using ProjectContar.Domain.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace ProjectContar.App.Results
{
    /// <summary>
    /// Represent app result.
    /// </summary>
    public class AppResult : AppResultContract
    {
        /// <summary>
        /// Create new App result.
        /// </summary>
        public AppResult()
        {
            this.Errors = new List<string>();
            this.Informations = new List<string>();
            this.Success = new List<string>();
            this.Warnings = new List<string>();
        }

        /// <summary>
        /// Create new App result.
        /// </summary>
        /// <param name="eventNotivications">Object with notifications.</param>
        public AppResult(
            EventNotificationServiceContract eventNotivications) : this()
        {
            foreach (var item in eventNotivications.Errors())
            {
                this.Errors.Add(item.ToString());
            }

            foreach (var item in eventNotivications.Informations())
            {
                this.Informations.Add(item.ToString());
            }

            foreach (var item in eventNotivications.Warnings())
            {
                this.Warnings.Add(item.ToString());
            }
        }

        /// <summary>
        /// Entity object result.
        /// </summary>
        public object Entity { get; set; }

        /// <summary>
        /// Store errors message.
        /// </summary>
        public List<string> Errors { get; }

        /// <summary>
        /// Indicate if has errors.
        /// </summary>
        public bool HasErrors { get { return this.Errors.Any(); } }

        /// <summary>
        /// Indicate if has information.
        /// </summary>
        public bool HasInformations { get { return this.Informations.Any(); } }

        /// <summary>
        /// Indicate if has Success.
        /// </summary>
        public bool HasSuccess { get { return this.Success.Any(); } }

        /// <summary>
        /// Indicate if has errors
        /// </summary>
        public bool HasWarnings { get { return this.Warnings.Any(); } }

        /// <summary>
        /// Store Information message.
        /// </summary>
        public List<string> Informations { get; }

        /// <summary>
        /// Store Success message.
        /// </summary>
        public List<string> Success { get; }

        /// <summary>
        /// Store Warnings message.
        /// </summary>
        public List<string> Warnings { get; }

        /// <summary>
        /// Add error messages,
        /// </summary>
        /// <param name="message">Message to error.</param>
        public void AddErrors(string message)
        {
            this.Errors.Add(message);
        }

        /// <summary>
        /// Add information messages,
        /// </summary>
        /// <param name="message">Message to information.</param>
        public void AddInformation(string message)
        {
            this.Informations.Add(message);
        }

        /// <summary>
        /// Add success messages,
        /// </summary>
        /// <param name="message">Message to success.</param>
        public void AddSuccess(string message)
        {
            this.Success.Add(message);
        }

        /// <summary>
        /// Add warning messages,
        /// </summary>
        /// <param name="message">Message to warning.</param>
        public void AddWarning(string message)
        {
            this.Warnings.Add(message);
        }
    }
}