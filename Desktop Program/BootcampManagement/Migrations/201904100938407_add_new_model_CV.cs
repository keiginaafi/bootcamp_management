namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_model_CV : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_T_CV",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Users_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_User", t => t.TB_M_Users_id)
                .Index(t => t.TB_M_Users_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_CV", "TB_M_Users_id", "dbo.TB_M_User");
            DropIndex("dbo.TB_T_CV", new[] { "TB_M_Users_id" });
            DropTable("dbo.TB_T_CV");
        }
    }
}
