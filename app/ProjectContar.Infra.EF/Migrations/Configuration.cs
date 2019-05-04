namespace ProjectContar.Infra.EF.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Configuration migrations.
    /// </summary>
    internal sealed class Configuration 
        : DbMigrationsConfiguration<ProjectContar.Infra.EF.Contexts.ContarDBMSSQL>
    {
        /// <summary>
        /// Create migrations.
        /// </summary>
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        /// <summary>
        /// Seed migration.
        /// </summary>
        /// <param name="context">Context to migration.</param>
        protected override void Seed(ProjectContar.Infra.EF.Contexts.ContarDBMSSQL context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}