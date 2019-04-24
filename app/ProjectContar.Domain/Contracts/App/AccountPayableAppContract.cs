using ProjectContar.Domain.Utils.Interfaces;
using System;

namespace ProjectContar.Domain.Contracts.App
{
    /// <summary>
    /// Account Payable app Actions.
    /// </summary>
    public interface AccountPayableAppContract : IServiceNotification
    {
        /// <summary>
        /// Add Account Payable.
        /// </summary>
        /// <param name="name">Account Name.</param>
        /// <param name="dueDate">Account Due Date.</param>
        /// <param name="amount">Account Amount to Pay.</param>
        /// <returns>True if added with success/ False if not.</returns>
        void Add(
            string name,
            DateTime? dueDate,
            decimal amount);
    }
}