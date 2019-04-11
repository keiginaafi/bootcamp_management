namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_model_programming_language : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_DevelopmentTool",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_ProgrammingLanguage",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_DevelopmentTool",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_DevelopmentTools_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_DevelopmentTool", t => t.TB_M_DevelopmentTools_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_DevelopmentTools_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_ProgrammingLanguage",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_ProgrammingLanguages_id = c.Int(),
                        TB_T_Cvs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_ProgrammingLanguage", t => t.TB_M_ProgrammingLanguages_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_Cvs_id)
                .Index(t => t.TB_M_ProgrammingLanguages_id)
                .Index(t => t.TB_T_Cvs_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_ProgrammingLanguage", "TB_T_Cvs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_ProgrammingLanguage", "TB_M_ProgrammingLanguages_id", "dbo.TB_M_ProgrammingLanguage");
            DropForeignKey("dbo.TB_T_DevelopmentTool", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_DevelopmentTool", "TB_M_DevelopmentTools_id", "dbo.TB_M_DevelopmentTool");
            DropIndex("dbo.TB_T_ProgrammingLanguage", new[] { "TB_T_Cvs_id" });
            DropIndex("dbo.TB_T_ProgrammingLanguage", new[] { "TB_M_ProgrammingLanguages_id" });
            DropIndex("dbo.TB_T_DevelopmentTool", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_DevelopmentTool", new[] { "TB_M_DevelopmentTools_id" });
            DropTable("dbo.TB_T_ProgrammingLanguage");
            DropTable("dbo.TB_T_DevelopmentTool");
            DropTable("dbo.TB_M_ProgrammingLanguage");
            DropTable("dbo.TB_M_DevelopmentTool");
        }
    }
}
