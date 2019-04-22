using System;

namespace ProjectContar.Domain.Entity
{
    /// <summary>
    /// Represents the entity to Account Payable
    /// </summary>
    public class AccountPayable
    {
        /// <summary>
        /// Store Account Amount to Pay.
        /// </summary>
        private decimal amount;

        /// <summary>
        /// Store Account Due Date.
        /// </summary>
        private DateTime dueDate;

        /// <summary>
        /// Store Account Name.
        /// </summary>
        private string name;

        /// <summary>
        /// Create new empty Account Payable.
        /// </summary>
        public AccountPayable()
        {
        }

        /// <summary>
        /// Create new Account Payable.
        /// </summary>
        /// <param name="name">Account Name.</param>
        /// <param name="dueDate">Account Due Date.</param>
        /// <param name="amount">Account Amount to Pay.</param>
        public AccountPayable(
            string name,
            DateTime dueDate,
            decimal amount)
        {
            this.name = name;
            this.dueDate = dueDate;
            this.amount = amount;
        }

        /// <summary>
        /// Amount to Pay.
        /// </summary>
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        /// <summary>
        /// Account Due Date.
        /// </summary>
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        /// <summary>
        /// Account Name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}