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

            this.HasKey(acp => new
            {
                acp.Name,
                acp.DueDate
            });

            this.Property(acp => acp.CreatedDate)
                .HasColumnName("CreateDate")
                .IsRequired();

            this.Property(acp => acp.ModifiedDate)
                .HasColumnName("ModifiedDate")
                .IsRequired();

            this.Property(acp => acp.Name)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("Name")
                .HasMaxLength(AccountPayable.NameMaximunLength)
                .IsRequired();

            this.Property(acp => acp.DueDate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("DueDate")
                .IsRequired();

            this.Property(acp => acp.Amount)
                .HasColumnName("Amount")
                .IsRequired();
        }
    }
}