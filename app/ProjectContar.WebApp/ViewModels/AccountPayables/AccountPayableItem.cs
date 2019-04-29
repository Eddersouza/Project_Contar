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
        public string Amount { get; set; }

        /// <summary>
        /// Due Date to Account.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Name to Account.
        /// </summary>
        public string Name { get; set; }
    }
}