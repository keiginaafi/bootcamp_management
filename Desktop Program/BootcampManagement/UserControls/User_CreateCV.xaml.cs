﻿using System;
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

namespace BootcampManagement.UserControls
{
    /// <summary>
    /// Interaction logic for User_CreateCV.xaml
    /// </summary>
    public partial class User_CreateCV : UserControl
    {
        public User_CreateCV()
        {
            InitializeComponent();
        }

        private void AddTraining_Btn_Click(object sender, RoutedEventArgs e)
        {
            AddTraining train = new AddTraining();
            train.Show();
        }
    }
}