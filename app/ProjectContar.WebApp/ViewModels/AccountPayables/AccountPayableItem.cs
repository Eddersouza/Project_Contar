using System;
using System.ComponentModel;

namespace ProjectContar.WebApp.ViewModels.AccountPayables
{
    /// <summary>
    /// Represents view to item Account Payable.
    /// </summary>
    public class AccountPayableItem
    {
        /// <summary>
        /// Create new item Account Payable.
        /// </summary>
        public AccountPayableItem()
        {
        }

        /// <summary>
        /// Create new item Account Payable.
        /// </summary>
        /// <param name="name">Name to Account.</param>
        /// <param name="dueDate">Due Date to Account.</param>
        /// <param name="amount">Amount account.</param>
        public AccountPayableItem(
            string name,
            DateTime dueDate,
            decimal amount)
        {
            this.Name = name;
            this.DueDate = dueDate.ToShortDateString();
            this.Amount = amount.ToString();
        }

        /// <summary>
        /// Amount account.
        /// </summary>
        [DisplayName("Valor")]
        public string Amount { get; set; }

        /// <summary>
        /// Due Date to Account.
        /// </summary>
        [DisplayName("Data de Vencimento")]
        public string DueDate { get; set; }

        /// <summary>
        /// Name to Account.
        /// </summary>
        [DisplayName("Nome")]
        public string Name { get; set; }
    }
}