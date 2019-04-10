namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_master_and_transaction_work_assignment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_WorkAssignment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Job_desk = c.String(),
                        Project_specification = c.String(),
                        Start_date = c.DateTime(nullable: false),
                        End_date = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_WorkAssignment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_WorkAssignments_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_WorkAssignment", t => t.TB_M_WorkAssignments_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_WorkAssignments_id)
                .Index(t => t.TB_T_CVs_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_WorkAssignment", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_WorkAssignment", "TB_M_WorkAssignments_id", "dbo.TB_M_WorkAssignment");
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_M_WorkAssignments_id" });
            DropTable("dbo.TB_T_WorkAssignment");
            DropTable("dbo.TB_M_WorkAssignment");
        }
    }
}
