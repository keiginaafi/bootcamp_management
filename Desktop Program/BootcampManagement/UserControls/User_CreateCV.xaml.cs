using BootcampManagement.Model;
﻿using BootcampManagement.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static BootcampManagement.LoginForm;

namespace BootcampManagement.UserControls
{
    /// <summary>
    /// Interaction logic for User_CreateCV.xaml
    /// </summary>
    public partial class User_CreateCV : UserControl
    {
        MyContext myContext = new MyContext();

        TB_T_CV TB_T_CVs = new TB_T_CV();
        TB_M_University TB_M_Universities = new TB_M_University();
        TB_M_Faculty TB_M_Faculties = new TB_M_Faculty();
        TB_M_Major TB_M_Majors = new TB_M_Major();
        TB_T_Education TB_T_Educations = new TB_T_Education();
        TB_M_Organization TB_M_Organizations = new TB_M_Organization();
        TB_T_Organization TB_T_Organizations = new TB_T_Organization();
        TB_M_Experience TB_M_Experiences = new TB_M_Experience();
        TB_T_Experiences TB_T_Experiences = new TB_T_Experiences();
        TB_M_Application TB_M_Applications = new TB_M_Application();
        TB_T_Application TB_T_Applications = new TB_T_Application();
        TB_M_Language TB_M_Languages = new TB_M_Language();
        TB_T_Language TB_T_Languages = new TB_T_Language();
        TB_M_DevelopmentTool TB_M_DevelopmentTools = new TB_M_DevelopmentTool();
        TB_T_DevelopmentTool TB_T_DevelopmentTools = new TB_T_DevelopmentTool();
        TB_M_ProgrammingLanguage TB_M_ProgrammingLanguages = new TB_M_ProgrammingLanguage();
        TB_T_ProgrammingLanguage TB_T_ProgrammingLanguages = new TB_T_ProgrammingLanguage();
        TB_M_Training TB_M_Trainings = new TB_M_Training();
        TB_T_Training TB_T_Trainings = new TB_T_Training();

        public User_CreateCV()
        {
            InitializeComponent();
        }

        private void AddTraining_Btn_Click(object sender, RoutedEventArgs e)
        {
            //AddTraining train = new AddTraining();
            //train.Show();
        }

        private void Save_Btn_Click(object sender, RoutedEventArgs e)
        {
            var uni = University_Tbox.Text;
            var major = Major_Tbox.Text;
            var faculty = Faculty_Tbox.Text;
            var gpa = Convert.ToDecimal(GPA_Tbox.Text);
            var graduate = GradationYear_Tbox.Text;
            var org = OrganizationName_Tbox.Text;
            var note = Note_Tbox.Text;
            var company = CompanyName_Tbox.Text;
            var periodstart = PeriodeStart_Tbox.Text;
            var periodend = PeriodeEnd_Tbox.Text;
            var expDesc = Description_Tbox.Text;
            var app = Application_Cmbbox.SelectedItem;
            var devtool = DevelopmentTool_Cmbbox.SelectedItem;
            var language = Language_Cmbbox.SelectedItem;
            var progLanguage = ProgrammingLanguage_Cmbbox.SelectedItem;

            TB_T_CVs.TB_M_Users = myContext.TB_M_Users.SingleOrDefault(x => x.id == GlobalVariables.userId);
            myContext.TB_T_CVs.Add(TB_T_CVs);

            TB_M_Universities.Name = uni;
            TB_M_Universities.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_M_Universities.Add(TB_M_Universities);

            TB_M_Faculties.Name = faculty;
            TB_M_Faculties.TB_M_Universities = TB_M_Universities;
            TB_M_Faculties.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_M_Universities.Add(TB_M_Universities);

            TB_M_Majors.Name = major;
            TB_M_Majors.TB_M_Faculties = TB_M_Faculties;
            TB_M_Majors.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_M_Universities.Add(TB_M_Universities);

            TB_T_Educations.GPA = gpa;
            TB_T_Educations.Graduation_Year = graduate;
            TB_T_Educations.TB_M_Majors = TB_M_Majors;
            TB_T_Educations.TB_T_CVs = TB_T_CVs;
            TB_T_Educations.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.SaveChanges();

            TB_M_Organizations.Name = org;
            TB_M_Organizations.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_M_Organizations.Add(TB_M_Organizations);

            TB_T_Organizations.Name = note;
            TB_T_Organizations.TB_M_Organizations = TB_M_Organizations;
            TB_T_Organizations.TB_T_CVs = TB_T_CVs;
            TB_T_Organizations.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_T_Organizations.Add(TB_T_Organizations);
            myContext.SaveChanges();

            TB_M_Experiences.Company_Name = company;
            TB_M_Experiences.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_M_Experiences.Add(TB_M_Experiences);

            TB_T_Experiences.Description = expDesc;
            TB_T_Experiences.End_year = periodend;
            TB_T_Experiences.TB_M_Experiences = TB_M_Experiences;
            TB_T_Experiences.TB_T_CVs = TB_T_CVs;
            TB_T_Experiences.CreateDate = DateTimeOffset.Now.LocalDateTime;
            myContext.TB_T_Experiences.Add(TB_T_Experiences);
            myContext.SaveChanges();

            TB_M_Applications = myContext.TB_M_Applications.Find(app);
            TB_T_Applications.TB_M_Applications = TB_M_Applications;
            TB_T_Applications.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_T_Applications.TB_T_CVs = TB_T_CVs;
            myContext.TB_T_Applications.Add(TB_T_Applications);
            myContext.SaveChanges();

            TB_M_Languages = myContext.TB_M_Languages.Find(app);
            TB_T_Languages.TB_M_Languages = TB_M_Languages;
            TB_T_Languages.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_T_Languages.TB_T_CVs = TB_T_CVs;
            myContext.TB_T_Languages.Add(TB_T_Languages);
            myContext.SaveChanges();

            TB_M_DevelopmentTools = myContext.TB_M_DevelopmentTools.Find(app);
            TB_T_DevelopmentTools.TB_M_DevelopmentTools = TB_M_DevelopmentTools;
            TB_T_DevelopmentTools.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_T_DevelopmentTools.TB_T_CVs = TB_T_CVs;
            myContext.TB_T_DevelopmentTools.Add(TB_T_DevelopmentTools);
            myContext.SaveChanges();

            TB_M_ProgrammingLanguages = myContext.TB_M_ProgrammingLanguages.Find(app);
            TB_T_ProgrammingLanguages.TB_M_ProgrammingLanguages = TB_M_ProgrammingLanguages;
            TB_T_ProgrammingLanguages.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_T_ProgrammingLanguages.TB_T_Cvs = TB_T_CVs;
            myContext.TB_T_ProgrammingLanguages.Add(TB_T_ProgrammingLanguages);
            myContext.SaveChanges();
        }
    }
}
