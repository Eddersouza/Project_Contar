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
                        IdAccount = c.Long(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdAccount);
            
        }
        
        public override void Down()
        {
            DropTable("df_contar.TB_AccountPayable");
        }
    }
}
