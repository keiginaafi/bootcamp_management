namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_model_trainer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Trainer",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Employees_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Employee", t => t.TB_M_Employees_id)
                .Index(t => t.TB_M_Employees_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Trainer", "TB_M_Employees_id", "dbo.TB_M_Employee");
            DropIndex("dbo.TB_M_Trainer", new[] { "TB_M_Employees_id" });
            DropTable("dbo.TB_M_Trainer");
        }
    }
}
