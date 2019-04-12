namespace BootcampManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model_revision : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_T_CVs_id", "dbo.TB_T_CV");
            DropForeignKey("dbo.TB_R_Grade", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_DailyScores_id", "dbo.TB_T_DailyScore");
            DropForeignKey("dbo.TB_R_Grade", "TB_T_WeeklyScores_id", "dbo.TB_T_WeeklyScore");
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_T_CVs_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_M_BootcampMembers_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_DailyScores_id" });
            DropIndex("dbo.TB_R_Grade", new[] { "TB_T_WeeklyScores_id" });
            AddColumn("dbo.TB_M_BootcampMember", "TB_R_Grades_id", c => c.Int());
            AddColumn("dbo.TB_M_User", "Photo", c => c.String());
            AddColumn("dbo.TB_M_Employee", "Gender", c => c.String());
            AddColumn("dbo.TB_M_Employee", "Photo", c => c.String());
            AddColumn("dbo.TB_T_Experiences", "Description", c => c.String());
            AddColumn("dbo.TB_T_Experiences", "End_year", c => c.String());
            AddColumn("dbo.TB_T_WorkAssignment", "Job_desk", c => c.String());
            AddColumn("dbo.TB_T_WorkAssignment", "Start_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.TB_T_WorkAssignment", "End_date", c => c.DateTime(nullable: false));
            CreateIndex("dbo.TB_M_BootcampMember", "TB_R_Grades_id");
            AddForeignKey("dbo.TB_M_BootcampMember", "TB_R_Grades_id", "dbo.TB_R_Grade", "id");
            DropColumn("dbo.TB_M_BootcampMember", "TB_T_CVs_id");
            DropColumn("dbo.TB_M_Experience", "Description");
            DropColumn("dbo.TB_M_Experience", "End_year");
            DropColumn("dbo.TB_M_WorkAssignment", "Job_desk");
            DropColumn("dbo.TB_M_WorkAssignment", "Start_date");
            DropColumn("dbo.TB_M_WorkAssignment", "End_date");
            DropColumn("dbo.TB_R_Grade", "TB_M_BootcampMembers_id");
            DropColumn("dbo.TB_R_Grade", "TB_T_DailyScores_id");
            DropColumn("dbo.TB_R_Grade", "TB_T_WeeklyScores_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TB_R_Grade", "TB_T_WeeklyScores_id", c => c.Int());
            AddColumn("dbo.TB_R_Grade", "TB_T_DailyScores_id", c => c.Int());
            AddColumn("dbo.TB_R_Grade", "TB_M_BootcampMembers_id", c => c.Int());
            AddColumn("dbo.TB_M_WorkAssignment", "End_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.TB_M_WorkAssignment", "Start_date", c => c.DateTime(nullable: false));
            AddColumn("dbo.TB_M_WorkAssignment", "Job_desk", c => c.String());
            AddColumn("dbo.TB_M_Experience", "End_year", c => c.String());
            AddColumn("dbo.TB_M_Experience", "Description", c => c.String());
            AddColumn("dbo.TB_M_BootcampMember", "TB_T_CVs_id", c => c.Int());
            DropForeignKey("dbo.TB_M_BootcampMember", "TB_R_Grades_id", "dbo.TB_R_Grade");
            DropIndex("dbo.TB_M_BootcampMember", new[] { "TB_R_Grades_id" });
            DropColumn("dbo.TB_T_WorkAssignment", "End_date");
            DropColumn("dbo.TB_T_WorkAssignment", "Start_date");
            DropColumn("dbo.TB_T_WorkAssignment", "Job_desk");
            DropColumn("dbo.TB_T_Experiences", "End_year");
            DropColumn("dbo.TB_T_Experiences", "Description");
            DropColumn("dbo.TB_M_Employee", "Photo");
            DropColumn("dbo.TB_M_Employee", "Gender");
            DropColumn("dbo.TB_M_User", "Photo");
            DropColumn("dbo.TB_M_BootcampMember", "TB_R_Grades_id");
            CreateIndex("dbo.TB_R_Grade", "TB_T_WeeklyScores_id");
            CreateIndex("dbo.TB_R_Grade", "TB_T_DailyScores_id");
            CreateIndex("dbo.TB_R_Grade", "TB_M_BootcampMembers_id");
            CreateIndex("dbo.TB_M_BootcampMember", "TB_T_CVs_id");
            AddForeignKey("dbo.TB_R_Grade", "TB_T_WeeklyScores_id", "dbo.TB_T_WeeklyScore", "id");
            AddForeignKey("dbo.TB_R_Grade", "TB_T_DailyScores_id", "dbo.TB_T_DailyScore", "id");
            AddForeignKey("dbo.TB_R_Grade", "TB_M_BootcampMembers_id", "dbo.TB_M_BootcampMember", "id");
            AddForeignKey("dbo.TB_M_BootcampMember", "TB_T_CVs_id", "dbo.TB_T_CV", "id");
        }
    }
}
