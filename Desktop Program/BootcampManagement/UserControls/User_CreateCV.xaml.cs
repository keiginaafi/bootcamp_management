<<<<<<< HEAD
﻿using BootcampManagement.Model;
=======
﻿using BootcampManagement.Forms;
>>>>>>> 0a9e0687592d5a9e73b1655c42f535b9bd7b97c2
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

        }
    }
}
