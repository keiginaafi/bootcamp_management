namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class almost_all_migration_and_fixed_region_district : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.TB_M_District", name: "TB_M_Regions_id", newName: "TB_M_Districts_id");
            RenameIndex(table: "dbo.TB_M_District", name: "IX_TB_M_Regions_id", newName: "IX_TB_M_Districts_id");
            CreateTable(
                "dbo.TB_M_Account",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Roles_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Role", t => t.TB_M_Roles_id)
                .Index(t => t.TB_M_Roles_id);
            
            CreateTable(
                "dbo.TB_M_Role",
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
                "dbo.TB_M_Application",
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
                "dbo.TB_T_CV",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Users_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_User", t => t.TB_M_Users_id)
                .Index(t => t.TB_M_Users_id);
            
            CreateTable(
                "dbo.TB_M_Department",
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
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Religions_id = c.Int(),
                        TB_M_Villages_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Religion", t => t.TB_M_Religions_id)
                .ForeignKey("dbo.TB_M_Village", t => t.TB_M_Villages_id)
                .Index(t => t.TB_M_Religions_id)
                .Index(t => t.TB_M_Villages_id);
            
            CreateTable(
                "dbo.TB_M_Experience",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(),
                        Description = c.String(),
                        End_year = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Faculty",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
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
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Language",
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
                "dbo.TB_M_Major",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Faculties_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Faculty", t => t.TB_M_Faculties_id)
                .Index(t => t.TB_M_Faculties_id);
            
            CreateTable(
                "dbo.TB_M_OperatingSystem",
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
                "dbo.TB_M_Organization",
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
                "dbo.TB_M_Trainer",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Employees_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Employee", t => t.TB_M_Employees_id)
                .Index(t => t.TB_M_Employees_id);
            
            CreateTable(
                "dbo.TB_M_Training",
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
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Application",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Applications_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Application", t => t.TB_M_Applications_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Applications_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_Education",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Graduation_Year = c.String(),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Majors_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Major", t => t.TB_M_Majors_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Majors_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_Experiences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Experiences_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Experience", t => t.TB_M_Experiences_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Experiences_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_Language",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Languages_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Language", t => t.TB_M_Languages_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Languages_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_OperatingSystem",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_OperatingSystems_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_OperatingSystem", t => t.TB_M_OperatingSystems_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_OperatingSystems_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_Organization",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Organizations_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Organization", t => t.TB_M_Organizations_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Organizations_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_Training",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Training_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Training", t => t.TB_M_Training_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_Training_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_T_WorkAssignment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
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
            DropForeignKey("dbo.TB_T_Training", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Training", "TB_M_Training_id", "dbo.TB_M_Training");
            DropForeignKey("dbo.TB_T_Organization", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Organization", "TB_M_Organizations_id", "dbo.TB_M_Organization");
            DropForeignKey("dbo.TB_T_OperatingSystem", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_OperatingSystem", "TB_M_OperatingSystems_id", "dbo.TB_M_OperatingSystem");
            DropForeignKey("dbo.TB_T_Language", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Language", "TB_M_Languages_id", "dbo.TB_M_Language");
            DropForeignKey("dbo.TB_T_Experiences", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Experiences", "TB_M_Experiences_id", "dbo.TB_M_Experience");
            DropForeignKey("dbo.TB_T_Education", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Education", "TB_M_Majors_id", "dbo.TB_M_Major");
            DropForeignKey("dbo.TB_T_Application", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Application", "TB_M_Applications_id", "dbo.TB_M_Application");
            DropForeignKey("dbo.TB_M_Trainer", "TB_M_Employees_id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Major", "TB_M_Faculties_id", "dbo.TB_M_Faculty");
            DropForeignKey("dbo.TB_M_Faculty", "TB_M_Universities_id", "dbo.TB_M_University");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_T_CV", "TB_M_Users_id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_Account", "TB_M_Roles_id", "dbo.TB_M_Role");
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_M_WorkAssignments_id" });
            DropIndex("dbo.TB_T_Training", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Training", new[] { "TB_M_Training_id" });
            DropIndex("dbo.TB_T_Organization", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Organization", new[] { "TB_M_Organizations_id" });
            DropIndex("dbo.TB_T_OperatingSystem", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_OperatingSystem", new[] { "TB_M_OperatingSystems_id" });
            DropIndex("dbo.TB_T_Language", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Language", new[] { "TB_M_Languages_id" });
            DropIndex("dbo.TB_T_Experiences", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Experiences", new[] { "TB_M_Experiences_id" });
            DropIndex("dbo.TB_T_Education", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Education", new[] { "TB_M_Majors_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_M_Applications_id" });
            DropIndex("dbo.TB_M_Trainer", new[] { "TB_M_Employees_id" });
            DropIndex("dbo.TB_M_Major", new[] { "TB_M_Faculties_id" });
            DropIndex("dbo.TB_M_Faculty", new[] { "TB_M_Universities_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Religions_id" });
            DropIndex("dbo.TB_T_CV", new[] { "TB_M_Users_id" });
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Roles_id" });
            DropTable("dbo.TB_T_WorkAssignment");
            DropTable("dbo.TB_T_Training");
            DropTable("dbo.TB_T_Organization");
            DropTable("dbo.TB_T_OperatingSystem");
            DropTable("dbo.TB_T_Language");
            DropTable("dbo.TB_T_Experiences");
            DropTable("dbo.TB_T_Education");
            DropTable("dbo.TB_T_Application");
            DropTable("dbo.TB_M_WorkAssignment");
            DropTable("dbo.TB_M_Training");
            DropTable("dbo.TB_M_Trainer");
            DropTable("dbo.TB_M_Organization");
            DropTable("dbo.TB_M_OperatingSystem");
            DropTable("dbo.TB_M_Major");
            DropTable("dbo.TB_M_Language");
            DropTable("dbo.TB_M_University");
            DropTable("dbo.TB_M_Faculty");
            DropTable("dbo.TB_M_Experience");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_T_CV");
            DropTable("dbo.TB_M_Application");
            DropTable("dbo.TB_M_Role");
            DropTable("dbo.TB_M_Account");
            RenameIndex(table: "dbo.TB_M_District", name: "IX_TB_M_Districts_id", newName: "IX_TB_M_Regions_id");
            RenameColumn(table: "dbo.TB_M_District", name: "TB_M_Districts_id", newName: "TB_M_Regions_id");
        }
    }
}
