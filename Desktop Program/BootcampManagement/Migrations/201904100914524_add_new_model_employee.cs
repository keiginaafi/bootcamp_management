namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_new_model_employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Employee",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        First_name = c.String(),
                        Last_name = c.String(),
                        Email = c.String(),
                        Contact = c.String(),
                        Date_of_birth = c.DateTime(nullable: false),
                        IsMarried = c.Boolean(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Religions_id = c.Int(),
                        TB_M_Villages_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Religion", t => t.TB_M_Religions_id)
                .ForeignKey("dbo.TB_M_Village", t => t.TB_M_Villages_id)
                .Index(t => t.TB_M_Religions_id)
                .Index(t => t.TB_M_Villages_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Religions_id" });
            DropTable("dbo.TB_M_Employee");
        }
    }
}
