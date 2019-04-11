namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixerrordebugg : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_T_ProgrammingLanguage", "TB_T_Cvs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_ProgrammingLanguage", "TB_M_ProgrammingLanguages_id", "dbo.TB_M_ProgrammingLanguage");
            DropForeignKey("dbo.TB_T_DevelopmentTool", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_T_DevelopmentTool", "TB_M_DevelopmentTools_id", "dbo.TB_M_DevelopmentTool");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Trainers_id", "dbo.TB_M_Trainer");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Rooms_id", "dbo.TB_M_Room");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Classs_id", "dbo.TB_M_Class");
            DropForeignKey("dbo.TB_T_Class", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_T_Class", "TB_M_Batchs_id", "dbo.TB_M_Batch");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_WeeklyScores_id", "dbo.TB_T_WeeklyScore");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_DailyScores_id", "dbo.TB_T_DailyScore");
            DropForeignKey("dbo.TB_R_Grade", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_M_Site", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_Users_id", "dbo.TB_M_User");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_Lockers_id", "dbo.TB_M_Locker");
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_M_AccessCards_id", "dbo.TB_M_AccessCard");
            DropIndex("dbo.TB_T_ProgrammingLanguage", new[] { "TB_T_Cvs_id" });
            DropIndex("dbo.TB_T_ProgrammingLanguage", new[] { "TB_M_ProgrammingLanguages_id" });
            DropIndex("dbo.TB_T_DevelopmentTool", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_T_DevelopmentTool", new[] { "TB_M_DevelopmentTools_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Trainers_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Rooms_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Classs_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_T_Class", new[] { "TB_M_Batchs_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_WeeklyScores_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_DailyScores_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_M_Site", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_Users_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_Lockers_id" });
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_M_AccessCards_id" });
            DropTable("dbo.TB_T_ProgrammingLanguage");
            DropTable("dbo.TB_T_DevelopmentTool");
            DropTable("dbo.TB_T_Class");
            DropTable("dbo.TB_T_WeeklyScore");
            DropTable("dbo.TB_T_DailyScore");
            DropTable("dbo.TB_R_Grade");
            DropTable("dbo.TB_M_Site");
            DropTable("dbo.TB_M_Room");
            DropTable("dbo.TB_M_ProgrammingLanguage");
            DropTable("dbo.TB_M_Lesson");
            DropTable("dbo.TB_M_DevelopmentTool");
            DropTable("dbo.TB_M_Class");
            DropTable("dbo.TB_M_Locker");
            DropTable("dbo.TB_M_BootcampMember");
            DropTable("dbo.TB_M_Batch");
            DropTable("dbo.TB_M_AccessCard");
        }
    }
}
