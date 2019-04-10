namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_model_account : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Account",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Roles_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Role", t => t.TB_M_Roles_id)
                .Index(t => t.TB_M_Roles_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Account", "TB_M_Roles_id", "dbo.TB_M_Role");
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Roles_id" });
            DropTable("dbo.TB_M_Account");
        }
    }
}
