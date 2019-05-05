namespace ProjectContar.Infra.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "df_contar.TB_AccountPayable",
                c => new
                    {
                        Name = c.String(nullable: false, maxLength: 20),
                        DueDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.Name, t.DueDate });
            
        }
        
        public override void Down()
        {
            DropTable("df_contar.TB_AccountPayable");
        }
    }
}
