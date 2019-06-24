using System.Collections.Generic;

namespace ProjectContar.Domain.Contracts
{
    /// <summary>
    /// Represent app result.
    /// </summary>
    public interface AppResultContract
    {
        /// <summary>
        /// Entity object result.
        /// </summary>
        object Entity { get; set; }

        /// <summary>
        /// Store errors message.
        /// </summary>
        List<string> Errors { get; }

        /// <summary>
        /// Indicate if has errors.
        /// </summary>
        bool HasErrors { get; }

        /// <summary>
        /// Indicate if has information.
        /// </summary>
        bool HasInformations { get; }

        /// <summary>
        /// Indicate if has Success.
        /// </summary>
        bool HasSuccess { get; }

        /// <summary>
        /// Indicate if has errors
        /// </summary>
        bool HasWarnings { get; }

        /// <summary>
        /// Store Information message.
        /// </summary>
        List<string> Informations { get; }

        /// <summary>
        /// Store Success message.
        /// </summary>
        List<string> Success { get; }

        /// <summary>
        /// Store Warnings message.
        /// </summary>
        List<string> Warnings { get; }

        /// <summary>
        /// Add error messages,
        /// </summary>
        /// <param name="message">Message to error.</param>
        void AddErrors(string message);

        /// <summary>
        /// Add information messages,
        /// </summary>
        /// <param name="message">Message to information.</param>
        void AddInformation(string message);

        /// <summary>
        /// Add success messages,
        /// </summary>
        /// <param name="message">Message to success.</param>
        void AddSuccess(string message);

        /// <summary>
        /// Add warning messages,
        /// </summary>
        /// <param name="message">Message to warning.</param>
        void AddWarning(string message);
    }
}