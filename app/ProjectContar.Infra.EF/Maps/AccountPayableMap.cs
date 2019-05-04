using ProjectContar.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ProjectContar.Infra.EF.Maps
{
    /// <summary>
    /// Map to entity Account Payable.
    /// </summary>
    public class AccountPayableMap
        : EntityTypeConfiguration<AccountPayable>
    {
        /// <summary>
        /// Map Account Payable.
        /// </summary>
        public AccountPayableMap()
        {
            this.ToTable("TB_AccountPayable", "df_contar");

            this.HasKey(acp => acp.Id);

            this.Property(acp => acp.Id)
                .HasColumnName("IdAccount")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            this.Property(acp => acp.CreatedDate)
                .HasColumnName("CreateDate")
                .IsRequired();

            this.Property(acp => acp.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            this.Property(acp => acp.Name)
                .HasColumnName("Name")
                .HasMaxLength(AccountPayable.NameMaximunLength)
                .IsRequired();

            this.Property(acp => acp.DueDate)
                .HasColumnName("DueDate")
                .IsRequired();

            this.Property(acp => acp.Amount)
                .HasColumnName("Amount")
                .IsRequired();
        }
    }
}