namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_master_and_transaction_language : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Language",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Language",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Languages_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Language", t => t.TB_M_Languages_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Languages_id)
                .Index(t => t.TB_T_CVs_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Language", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Language", "TB_M_Languages_id", "dbo.TB_M_Language");
            DropIndex("dbo.TB_T_Language", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Language", new[] { "TB_M_Languages_id" });
            DropTable("dbo.TB_T_Language");
            DropTable("dbo.TB_M_Language");
        }
    }
}
