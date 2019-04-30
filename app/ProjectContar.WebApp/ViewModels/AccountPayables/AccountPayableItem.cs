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