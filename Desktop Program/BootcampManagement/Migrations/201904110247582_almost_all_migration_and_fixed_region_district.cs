namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class almost_all_migration_and_fixed_region_district : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TB_M_Role", newName: "TB_M_Sub_District");
            DropForeignKey("dbo.TB_M_Account", "TB_M_Roles_id", "dbo.TB_M_Role");
            DropForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropForeignKey("dbo.TB_M_District", "TB_M_Regions_id", "dbo.TB_M_Region");
            DropForeignKey("dbo.TB_T_CV", "TB_M_Users_id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Faculty", "TB_M_Universities_id", "dbo.TB_M_University");
            DropForeignKey("dbo.TB_M_Major", "TB_M_Faculties_id", "dbo.TB_M_Faculty");
            DropForeignKey("dbo.TB_M_Trainer", "TB_M_Employees_id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_T_Application", "TB_M_Applications_id", "dbo.TB_M_Application");
            DropForeignKey("dbo.TB_T_Application", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Education", "TB_M_Majors_id", "dbo.TB_M_Major");
            DropForeignKey("dbo.TB_T_Education", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Experiences", "TB_M_Experiences_id", "dbo.TB_M_Experience");
            DropForeignKey("dbo.TB_T_Experiences", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Language", "TB_M_Languages_id", "dbo.TB_M_Language");
            DropForeignKey("dbo.TB_T_Language", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_OperatingSystem", "TB_M_OperatingSystems_id", "dbo.TB_M_OperatingSystem");
            DropForeignKey("dbo.TB_T_OperatingSystem", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Organization", "TB_M_Organizations_id", "dbo.TB_M_Organization");
            DropForeignKey("dbo.TB_T_Organization", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Training", "TB_M_Training_id", "dbo.TB_M_Training");
            DropForeignKey("dbo.TB_T_Training", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_WorkAssignment", "TB_M_WorkAssignments_id", "dbo.TB_M_WorkAssignment");
            DropForeignKey("dbo.TB_T_WorkAssignment", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Roles_id" });
            DropIndex("dbo.TB_T_CV", new[] { "TB_M_Users_id" });
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Regions_id" });
            DropIndex("dbo.TB_M_Region", new[] { "TB_M_Provinces_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Religions_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_Faculty", new[] { "TB_M_Universities_id" });
            DropIndex("dbo.TB_M_Major", new[] { "TB_M_Faculties_id" });
            DropIndex("dbo.TB_M_Trainer", new[] { "TB_M_Employees_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_M_Applications_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Education", new[] { "TB_M_Majors_id" });
            DropIndex("dbo.TB_T_Education", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Experiences", new[] { "TB_M_Experiences_id" });
            DropIndex("dbo.TB_T_Experiences", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Language", new[] { "TB_M_Languages_id" });
            DropIndex("dbo.TB_T_Language", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_OperatingSystem", new[] { "TB_M_OperatingSystems_id" });
            DropIndex("dbo.TB_T_OperatingSystem", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Organization", new[] { "TB_M_Organizations_id" });
            DropIndex("dbo.TB_T_Organization", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Training", new[] { "TB_M_Training_id" });
            DropIndex("dbo.TB_T_Training", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_M_WorkAssignments_id" });
            DropIndex("dbo.TB_T_WorkAssignment", new[] { "TB_T_CVs_id" });
            AddColumn("dbo.TB_M_Sub_District", "TB_M_Districts_id", c => c.Int());
            AddColumn("dbo.TB_M_District", "TB_M_Provinces_id", c => c.Int());
            AlterColumn("dbo.TB_M_Sub_District", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Sub_District", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTime());
            CreateIndex("dbo.TB_M_Sub_District", "TB_M_Districts_id");
            CreateIndex("dbo.TB_M_District", "TB_M_Provinces_id");
            AddForeignKey("dbo.TB_M_District", "TB_M_Provinces_id", "dbo.TB_M_Province", "id");
            AddForeignKey("dbo.TB_M_Sub_District", "TB_M_Districts_id", "dbo.TB_M_District", "id");
            DropColumn("dbo.TB_M_District", "TB_M_Regions_id");
            DropTable("dbo.TB_M_Account");
            DropTable("dbo.TB_M_Application");
            DropTable("dbo.TB_T_CV");
            DropTable("dbo.TB_M_Region");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_M_Experience");
            DropTable("dbo.TB_M_Faculty");
            DropTable("dbo.TB_M_University");
            DropTable("dbo.TB_M_Language");
            DropTable("dbo.TB_M_Major");
            DropTable("dbo.TB_M_OperatingSystem");
            DropTable("dbo.TB_M_Organization");
            DropTable("dbo.TB_M_Trainer");
            DropTable("dbo.TB_M_Training");
            DropTable("dbo.TB_M_WorkAssignment");
            DropTable("dbo.TB_T_Application");
            DropTable("dbo.TB_T_Education");
            DropTable("dbo.TB_T_Experiences");
            DropTable("dbo.TB_T_Language");
            DropTable("dbo.TB_T_OperatingSystem");
            DropTable("dbo.TB_T_Organization");
            DropTable("dbo.TB_T_Training");
            DropTable("dbo.TB_T_WorkAssignment");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Training",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Training_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Organization",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Organizations_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_OperatingSystem",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_OperatingSystems_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Experiences",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Experiences_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_Application",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Applications_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
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
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Training",
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Organization",
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
                "dbo.TB_M_OperatingSystem",
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
                .PrimaryKey(t => t.id);
            
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
                .PrimaryKey(t => t.id);
            
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
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
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
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Religions_id = c.Int(),
                        TB_M_Villages_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Department",
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
                "dbo.TB_M_Region",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        DeleteDate = c.DateTime(nullable: false),
                        TB_M_Provinces_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
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
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_M_Application",
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
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.TB_M_District", "TB_M_Regions_id", c => c.Int());
            DropForeignKey("dbo.TB_M_Sub_District", "TB_M_Districts_id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_District", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Provinces_id" });
            DropIndex("dbo.TB_M_Sub_District", new[] { "TB_M_Districts_id" });
            AlterColumn("dbo.TB_M_Province", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Province", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_District", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Village", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Village", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Religion", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "EditDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Sub_District", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Sub_District", "EditDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.TB_M_District", "TB_M_Provinces_id");
            DropColumn("dbo.TB_M_Sub_District", "TB_M_Districts_id");
            CreateIndex("dbo.TB_T_WorkAssignment", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_WorkAssignment", "TB_M_WorkAssignments_id");
            CreateIndex("dbo.TB_T_Training", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Training", "TB_M_Training_id");
            CreateIndex("dbo.TB_T_Organization", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Organization", "TB_M_Organizations_id");
            CreateIndex("dbo.TB_T_OperatingSystem", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_OperatingSystem", "TB_M_OperatingSystems_id");
            CreateIndex("dbo.TB_T_Language", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Language", "TB_M_Languages_id");
            CreateIndex("dbo.TB_T_Experiences", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Experiences", "TB_M_Experiences_id");
            CreateIndex("dbo.TB_T_Education", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Education", "TB_M_Majors_id");
            CreateIndex("dbo.TB_T_Application", "TB_T_CVs_id");
            CreateIndex("dbo.TB_T_Application", "TB_M_Applications_id");
            CreateIndex("dbo.TB_M_Trainer", "TB_M_Employees_id");
            CreateIndex("dbo.TB_M_Major", "TB_M_Faculties_id");
            CreateIndex("dbo.TB_M_Faculty", "TB_M_Universities_id");
            CreateIndex("dbo.TB_M_Employee", "TB_M_Villages_id");
            CreateIndex("dbo.TB_M_Employee", "TB_M_Religions_id");
            CreateIndex("dbo.TB_M_Region", "TB_M_Provinces_id");
            CreateIndex("dbo.TB_M_District", "TB_M_Regions_id");
            CreateIndex("dbo.TB_T_CV", "TB_M_Users_id");
            CreateIndex("dbo.TB_M_Account", "TB_M_Roles_id");
            AddForeignKey("dbo.TB_T_WorkAssignment", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_WorkAssignment", "TB_M_WorkAssignments_id", "dbo.TB_M_WorkAssignment", "id");
            AddForeignKey("dbo.TB_T_Training", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Training", "TB_M_Training_id", "dbo.TB_M_Training", "id");
            AddForeignKey("dbo.TB_T_Organization", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Organization", "TB_M_Organizations_id", "dbo.TB_M_Organization", "id");
            AddForeignKey("dbo.TB_T_OperatingSystem", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_OperatingSystem", "TB_M_OperatingSystems_id", "dbo.TB_M_OperatingSystem", "id");
            AddForeignKey("dbo.TB_T_Language", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Language", "TB_M_Languages_id", "dbo.TB_M_Language", "id");
            AddForeignKey("dbo.TB_T_Experiences", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Experiences", "TB_M_Experiences_id", "dbo.TB_M_Experience", "id");
            AddForeignKey("dbo.TB_T_Education", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Education", "TB_M_Majors_id", "dbo.TB_M_Major", "id");
            AddForeignKey("dbo.TB_T_Application", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
            AddForeignKey("dbo.TB_T_Application", "TB_M_Applications_id", "dbo.TB_M_Application", "id");
            AddForeignKey("dbo.TB_M_Trainer", "TB_M_Employees_id", "dbo.TB_M_Employee", "id");
            AddForeignKey("dbo.TB_M_Major", "TB_M_Faculties_id", "dbo.TB_M_Faculty", "id");
            AddForeignKey("dbo.TB_M_Faculty", "TB_M_Universities_id", "dbo.TB_M_University", "id");
            AddForeignKey("dbo.TB_M_Employee", "TB_M_Villages_id", "dbo.TB_M_Village", "id");
            AddForeignKey("dbo.TB_M_Employee", "TB_M_Religions_id", "dbo.TB_M_Religion", "id");
            AddForeignKey("dbo.TB_T_CV", "TB_M_Users_id", "dbo.TB_M_User", "id");
            AddForeignKey("dbo.TB_M_District", "TB_M_Regions_id", "dbo.TB_M_Region", "id");
            AddForeignKey("dbo.TB_M_Region", "TB_M_Provinces_id", "dbo.TB_M_Province", "id");
            AddForeignKey("dbo.TB_M_Account", "TB_M_Roles_id", "dbo.TB_M_Role", "id");
            RenameTable(name: "dbo.TB_M_Sub_District", newName: "TB_M_Role");
        }
    }
}
