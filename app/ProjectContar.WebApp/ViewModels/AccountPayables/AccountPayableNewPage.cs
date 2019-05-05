using ProjectContar.WebApp.ViewModels.Shared;

namespace ProjectContar.WebApp.ViewModels.AccountPayables
{
    /// <summary>
    /// Represents view to page new Account Payable.
    /// </summary>
    public class AccountPayableNewPage
    {
        /// <summary>
        /// Create new view to page new Account Payable.
        /// </summary>
        public AccountPayableNewPage()
        {
            Item = new AccountPayableItem();
        }

        /// <summary>
        /// Represents the Account Payable data.
        /// </summary>
        public AccountPayableItem Item { get; set; }
    }
}