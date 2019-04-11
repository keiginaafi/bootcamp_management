namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_M_AccessCard",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Number_access = c.String(),
                        Date_accesscard = c.DateTime(nullable: false),
                        End_Dateaccesscard = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            
            
            CreateTable(
                "dbo.TB_M_Batch",
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
                "dbo.TB_M_BootcampMember",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Join_date = c.DateTime(nullable: false),
                        Last_date = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_AccessCards_id = c.Int(),
                        TB_M_Lockers_id = c.Int(),
                        TB_M_Users_id = c.Int(),
                        TB_T_CVs_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_AccessCard", t => t.TB_M_AccessCards_id)
                .ForeignKey("dbo.TB_M_Locker", t => t.TB_M_Lockers_id)
                .ForeignKey("dbo.TB_M_User", t => t.TB_M_Users_id)
                .ForeignKey("dbo.TB_T_CV", t => t.TB_T_CVs_id)
                .Index(t => t.TB_M_AccessCards_id)
                .Index(t => t.TB_M_Lockers_id)
                .Index(t => t.TB_M_Users_id)
                .Index(t => t.TB_T_CVs_id);
            
            CreateTable(
                "dbo.TB_M_Locker",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Number_locker = c.String(),
                        Date_locker = c.DateTime(nullable: false),
                        End_DateLocker = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            
            CreateTable(
                "dbo.TB_M_Class",
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
                "dbo.TB_M_Lesson",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tittle = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            
            
            CreateTable(
                "dbo.TB_M_Room",
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
                "dbo.TB_M_Site",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Division = c.String(),
                        DateOnBoardSite = c.DateTime(nullable: false),
                        LongTimeDUration = c.DateTime(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_BootcampMembers_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_BootcampMember", t => t.TB_M_BootcampMembers_id)
                .Index(t => t.TB_M_BootcampMembers_id);
            
            
            CreateTable(
                "dbo.TB_R_Grade",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_BootcampMembers_id = c.Int(),
                        TB_T_DailyScores_id = c.Int(),
                        TB_T_WeeklyScores_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_BootcampMember", t => t.TB_M_BootcampMembers_id)
                .ForeignKey("dbo.TB_T_DailyScore", t => t.TB_T_DailyScores_id)
                .ForeignKey("dbo.TB_T_WeeklyScore", t => t.TB_T_WeeklyScores_id)
                .Index(t => t.TB_M_BootcampMembers_id)
                .Index(t => t.TB_T_DailyScores_id)
                .Index(t => t.TB_T_WeeklyScores_id);
            
            CreateTable(
                "dbo.TB_T_DailyScore",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Score = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.TB_T_WeeklyScore",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Score = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            
            CreateTable(
                "dbo.TB_T_Class",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        IsDelete = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        EditDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        TB_M_Batchs_id = c.Int(),
                        TB_M_BootcampMembers_id = c.Int(),
                        TB_M_Classs_id = c.Int(),
                        TB_M_Rooms_id = c.Int(),
                        TB_M_Trainers_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.TB_M_Batch", t => t.TB_M_Batchs_id)
                .ForeignKey("dbo.TB_M_BootcampMember", t => t.TB_M_BootcampMembers_id)
                .ForeignKey("dbo.TB_M_Class", t => t.TB_M_Classs_id)
                .ForeignKey("dbo.TB_M_Room", t => t.TB_M_Rooms_id)
                .ForeignKey("dbo.TB_M_Trainer", t => t.TB_M_Trainers_id)
                .Index(t => t.TB_M_Batchs_id)
                .Index(t => t.TB_M_BootcampMembers_id)
                .Index(t => t.TB_M_Classs_id)
                .Index(t => t.TB_M_Rooms_id)
                .Index(t => t.TB_M_Trainers_id);
            
            
            
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
            DropForeignKey("dbo.TB_T_Class", "TB_M_Trainers_id", "dbo.TB_M_Trainer");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Rooms_id", "dbo.TB_M_Room");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Classs_id", "dbo.TB_M_Class");
            DropForeignKey("dbo.TB_T_Class", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Batchs_id", "dbo.TB_M_Batch");
            DropForeignKey("dbo.TB_T_Application", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_Application", "TB_M_Applications_id", "dbo.TB_M_Application");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_WeeklyScores_id", "dbo.TB_T_WeeklyScore");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_DailyScores_id", "dbo.TB_T_DailyScore");
            DropForeignKey("dbo.TB_R_Grade", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_M_Trainer", "TB_M_Employees_id", "dbo.TB_M_Employee");
            DropForeignKey("dbo.TB_M_Sub_District", "TB_M_Districts_id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_Site", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_M_Major", "TB_M_Faculties_id", "dbo.TB_M_Faculty");
            DropForeignKey("dbo.TB_M_Faculty", "TB_M_Universities_id", "dbo.TB_M_University");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Employee", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_CV", "TB_M_Users_id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_Users_id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_User", "TB_M_Villages_id", "dbo.TB_M_Village");
            DropForeignKey("dbo.TB_M_Village", "TB_M_Districts_id", "dbo.TB_M_District");
            DropForeignKey("dbo.TB_M_District", "TB_M_Provinces_id", "dbo.TB_M_Province");
            DropForeignKey("dbo.TB_M_User", "TB_M_Religions_id", "dbo.TB_M_Religion");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_Lockers_id", "dbo.TB_M_Locker");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_AccessCards_id", "dbo.TB_M_AccessCard");
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
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Trainers_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Rooms_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Classs_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Batchs_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_Application", new[] { "TB_M_Applications_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_WeeklyScores_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_DailyScores_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_M_Trainer", new[] { "TB_M_Employees_id" });
            DropIndex("dbo.TB_M_Sub_District", new[] { "TB_M_Districts_id" });
            DropIndex("dbo.TB_M_Site", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_M_Major", new[] { "TB_M_Faculties_id" });
            DropIndex("dbo.TB_M_Faculty", new[] { "TB_M_Universities_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_Employee", new[] { "TB_M_Religions_id" });
            DropIndex("dbo.TB_T_CV", new[] { "TB_M_Users_id" });
            DropIndex("dbo.TB_M_District", new[] { "TB_M_Provinces_id" });
            DropIndex("dbo.TB_M_Village", new[] { "TB_M_Districts_id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Villages_id" });
            DropIndex("dbo.TB_M_User", new[] { "TB_M_Religions_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_Users_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_Lockers_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_AccessCards_id" });
            DropIndex("dbo.TB_M_Account", new[] { "TB_M_Roles_id" });
            DropTable("dbo.TB_T_WorkAssignment");
            DropTable("dbo.TB_M_Training");
            DropTable("dbo.TB_T_Training");
            DropTable("dbo.TB_T_Organization");
            DropTable("dbo.TB_T_OperatingSystem");
            DropTable("dbo.TB_T_Language");
            DropTable("dbo.TB_T_Experiences");
            DropTable("dbo.TB_T_Education");
            DropTable("dbo.TB_T_Class");
            DropTable("dbo.TB_T_Application");
            DropTable("dbo.TB_T_WeeklyScore");
            DropTable("dbo.TB_T_DailyScore");
            DropTable("dbo.TB_R_Grade");
            DropTable("dbo.TB_M_WorkAssignment");
            DropTable("dbo.TB_M_Trainer");
            DropTable("dbo.TB_M_Sub_District");
            DropTable("dbo.TB_M_Site");
            DropTable("dbo.TB_M_Room");
            DropTable("dbo.TB_M_Organization");
            DropTable("dbo.TB_M_OperatingSystem");
            DropTable("dbo.TB_M_Major");
            DropTable("dbo.TB_M_Lesson");
            DropTable("dbo.TB_M_Language");
            DropTable("dbo.TB_M_University");
            DropTable("dbo.TB_M_Faculty");
            DropTable("dbo.TB_M_Experience");
            DropTable("dbo.TB_M_Employee");
            DropTable("dbo.TB_M_Department");
            DropTable("dbo.TB_M_Class");
            DropTable("dbo.TB_T_CV");
            DropTable("dbo.TB_M_Province");
            DropTable("dbo.TB_M_District");
            DropTable("dbo.TB_M_Village");
            DropTable("dbo.TB_M_Religion");
            DropTable("dbo.TB_M_User");
            DropTable("dbo.TB_M_Locker");
            DropTable("dbo.TB_M_BootcampMember");
            DropTable("dbo.TB_M_Batch");
            DropTable("dbo.TB_M_Application");
            DropTable("dbo.TB_M_Role");
            DropTable("dbo.TB_M_Account");
            DropTable("dbo.TB_M_AccessCard");
        }
    }
}
