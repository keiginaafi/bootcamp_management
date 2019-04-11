using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement
{
    class MyContext :DbContext
    {
        public MyContext() : base("MyContext")
        {

        }

        public DbSet<TB_M_Sub_District> TB_M_Sub_Districts { get; set; }
        public DbSet<TB_M_Role> TB_M_Roles { get; set; }
        public DbSet<TB_M_Account> TB_M_Accounts { get; set; }
        public DbSet<TB_M_Province> TB_M_Provinces { get; set; }
        public DbSet<TB_M_District> TB_M_Regions { get; set; }
        public DbSet<TB_M_Religion> TB_M_Religions { get; set; }
        public DbSet<TB_M_User> TB_M_Users { get; set; }
        public DbSet<TB_M_Village> TB_M_Villages { get; set; }
        public DbSet<TB_M_Employee> TB_M_Employees { get; set; }
        public DbSet<TB_M_Department> TB_M_Departments { get; set; }
        public DbSet<TB_M_Trainer> TB_M_Trainers { get; set; }
        public DbSet<TB_T_CV> TB_M_CVs { get; set; }
        public DbSet<TB_T_Education> TB_T_Educations { get; set; }
        public DbSet<TB_M_University> TB_M_Universities { get; set; }
        public DbSet<TB_M_Faculty> TB_M_Faculties { get; set; }
        public DbSet<TB_M_Major> TB_M_Majors { get; set; }
        public DbSet<TB_M_Organization> TB_M_Organizations { get; set; }
        public DbSet<TB_T_Organization> TB_T_Organizations { get; set; }
        public DbSet<TB_M_Experience> TB_M_Experiences { get; set; }
        public DbSet<TB_T_Experiences> TB_T_Experiences { get; set; }
        public DbSet<TB_M_Application> TB_M_Applications { get; set; }
        public DbSet<TB_T_Application> TB_T_Applications { get; set; }
        public DbSet<TB_M_Language> TB_M_Languages { get; set; }
        public DbSet<TB_T_Language> TB_T_Languages { get; set; }
        public DbSet<TB_M_WorkAssignment> TB_M_WorkAssignments { get; set; }
        public DbSet<TB_T_WorkAssignment> TB_T_WorkAssignments { get; set; }
        public DbSet<TB_M_OperatingSystem> TB_M_OperatingSystems { get; set; }
        public DbSet<TB_T_OperatingSystem> TB_T_OperatingSystems { get; set; }
        public DbSet<TB_M_Training> TB_M_Trainings { get; set; }
        public DbSet<TB_T_Training> TB_T_Trainings { get; set; }
        public DbSet<TB_M_Room> TB_M_Rooms { get; set; }
        public DbSet<TB_M_Batch> TB_M_Batchs { get; set; }
        public DbSet<TB_M_Class> TB_M_Classs { get; set; }
        public DbSet<TB_M_Trainer> TB_M_Trainer { get; set; }
        public DbSet<TB_M_BootcampMember> TB_M_BootcampMembers { get; set; }
        public DbSet<TB_T_Class> TB_T_Classs { get; set; }
        public DbSet<TB_M_Lesson> TB_M_Lessons { get; set; }
        public DbSet<TB_M_Locker> TB_M_Locker { get; set; }
        public DbSet<TB_M_AccessCard> TB_M_AccessCards { get; set; }
        public DbSet<TB_M_Site> TB_M_Sites { get; set; }
        public DbSet<TB_R_Grade> TB_R_Grades { get; set; }
        public DbSet<TB_T_WeeklyScore> TB_T_WeeklyScores { get; set; }
        public DbSet<TB_T_DailyScore> TB_T_DailyScores { get; set; }


    }
}
