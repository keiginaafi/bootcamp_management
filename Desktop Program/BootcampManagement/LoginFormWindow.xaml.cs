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
using System.Windows.Shapes;

namespace BootcampManagement
{
    /// <summary>
    /// Interaction logic for LoginFormWindow.xaml
    /// </summary>
    public partial class LoginFormWindow : Window
    {
        public LoginFormWindow()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Txt_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
