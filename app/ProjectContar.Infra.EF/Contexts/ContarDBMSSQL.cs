using ProjectContar.Domain.Entities.Base;
using ProjectContar.Infra.EF.Maps;
using System;
using System.Data.Entity;

namespace ProjectContar.Infra.EF.Contexts
{
    /// <summary>
    /// Represents context to MSSQL contar db
    /// </summary>
    public class ContarDBMSSQL : DbContext
    {
        /// <summary>
        /// New context ot MSSSQL contar db.
        /// </summary>
        public ContarDBMSSQL()
            : base("ContarMSSSQLConnection")
        {
        }

        /// <summary>
        /// Actions on create model.
        /// </summary>
        /// <param name="modelBuilder">Object with data to create model.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountPayableMap());
        }

        /// <summary>
        /// Save changes in entity.
        /// </summary>
        /// <returns>Base save.</returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = (Entity)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedDate = DateTime.Now;
                    entity.ModifiedDate = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entity.ModifiedDate = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}