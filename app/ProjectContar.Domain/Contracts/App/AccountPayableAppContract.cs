using System;
using System.Collections.Generic;

namespace ProjectContar.Domain.Contracts.App
{
    /// <summary>
    /// Account Payable app Actions.
    /// </summary>
    public interface AccountPayableAppContract
    {
        /// <summary>
        /// Add Account Payable.
        /// </summary>
        /// <param name="name">Account Name.</param>
        /// <param name="dueDate">Account Due Date.</param>
        /// <param name="amount">Account Amount to Pay.</param>
        /// <param name="errors">Errors in add.</param>
        /// <returns>True if added with success/ False if not.</returns>
        bool Add(
            string name,
            DateTime? dueDate,
            decimal amount,
            ref List<string> errors);
    }
}