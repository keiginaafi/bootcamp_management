namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_education_models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_Faculty",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Universities_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_University", t => t.TB_M_Universities_id)
                .Index(t => t.TB_M_Universities_id);
            
            CreateTable(
                "dbo.TB_M_University",
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
                "dbo.TB_M_Major",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Faculties_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Faculty", t => t.TB_M_Faculties_id)
                .Index(t => t.TB_M_Faculties_id);
            
            CreateTable(
                "dbo.TB_T_Education",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Graduation_Year = c.String(),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Majors_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Major", t => t.TB_M_Majors_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Majors_id)
                .Index(t => t.TB_T_CVs_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_Education", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Education", "TB_M_Majors_id", "dbo.TB_M_Major");
            DropForeignKey("dbo.TB_M_Major", "TB_M_Faculties_id", "dbo.TB_M_Faculty");
            DropForeignKey("dbo.TB_M_Faculty", "TB_M_Universities_id", "dbo.TB_M_University");
            DropIndex("dbo.TB_T_Education", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Education", new[] { "TB_M_Majors_id" });
            DropIndex("dbo.TB_M_Major", new[] { "TB_M_Faculties_id" });
            DropIndex("dbo.TB_M_Faculty", new[] { "TB_M_Universities_id" });
            DropTable("dbo.TB_T_Education");
            DropTable("dbo.TB_M_Major");
            DropTable("dbo.TB_M_University");
            DropTable("dbo.TB_M_Faculty");
        }
    }
}
