using edrsys.EventNotification;
using edrsys.EventNotification.Levels;
using ProjectContar.Domain.Entities.Base;
using System;
using System.Linq.Expressions;

namespace ProjectContar.Domain.Entities
{
    /// <summary>
    /// Represents the entity to Account Payable
    /// </summary>
    public class AccountPayable : Entity
    {
        /// <summary>
        /// Maximun Length to Field name.
        /// </summary>
        public const int NameMaximunLength = 20;

        /// <summary>
        /// Minimun Length to Field name.
        /// </summary>
        public const int NameMinimunLength = 3;

        /// <summary>
        /// Function default to amount.
        /// </summary>
        public static readonly Expression<Func<AccountPayable, decimal>> AliasAmount = p => p.amount;

        /// <summary>
        /// Function default to due date.
        /// </summary>
        public static readonly Expression<Func<AccountPayable, DateTime?>> AliasDueDate = p => p.dueDate;

        /// <summary>
        /// Function default to name.
        /// </summary>
        public static readonly Expression<Func<AccountPayable, string>> AliasName = p => p.name;

        /// <summary>
        /// Warning to field Amount Zero.
        /// </summary>
        public static EventNotificationDescription AmountDontBeZero =
            new EventNotificationDescription(
                "O Campo Valor deve ser maior que 0.",
                new EventNotificationWarning());

        /// <summary>
        /// Warning to field Due Date empty.
        /// </summary>
        public static EventNotificationDescription DueDateDoNotEmpty =
            new EventNotificationDescription(
                "O Campo Data não pode ser vazio.",
                new EventNotificationWarning());

        /// <summary>
        /// Warning to field Name less than minimum length.
        /// </summary>
        public static EventNotificationDescription FieldNameMustBeGreaterThan =
            new EventNotificationDescription(
                "O Campo Nome deve ser maior ou igual a {0} caracteres.",
                new EventNotificationWarning(),
                NameMinimunLength.ToString());

        /// <summary>
        /// Warning to field Name less than minimum length.
        /// </summary>
        public static EventNotificationDescription FieldNameMustBeLessThan =
            new EventNotificationDescription(
                "O Campo Nome deve ser menor ou igual a {0} caracteres.",
                new EventNotificationWarning(),
                NameMaximunLength.ToString());

        /// <summary>
        /// Warning to field Name empty.
        /// </summary>
        public static EventNotificationDescription RequiredFieldName =
            new EventNotificationDescription(
                "O Campo Nome é obrigatório.",
                new EventNotificationWarning());

        /// <summary>
        /// Store Account Amount to Pay.
        /// </summary>
        private decimal amount;

        /// <summary>
        /// Store Account Due Date.
        /// </summary>
        private DateTime? dueDate;

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
            DateTime? dueDate
            ) : this()
        {
            this.name = name;
            this.dueDate = dueDate;

            TestFieldIsEmpty(this.name, RequiredFieldName);

            if (this.IsValid())
                TestCondition(this.Name.Length < NameMinimunLength, FieldNameMustBeGreaterThan);

            if (this.IsValid())
                TestCondition(this.Name.Length > NameMaximunLength, FieldNameMustBeLessThan);

            TestCondition(this.DueDate == null, DueDateDoNotEmpty);
        }

        /// <summary>
        /// Create new Account Payable.
        /// </summary>
        /// <param name="name">Account Name.</param>
        /// <param name="dueDate">Account Due Date.</param>
        /// <param name="amount">Account Amount to Pay.</param>
        public AccountPayable(
            string name,
            DateTime? dueDate,
            decimal amount) : this(name, dueDate)
        {
            this.amount = amount;
                        
            TestCondition(this.amount == 0, AmountDontBeZero);            
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
        public DateTime? DueDate
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