using BootcampManagement.Controller;
using BootcampManagement.Interface;
using BootcampManagement.Model;
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
using System.Windows.Shapes;

namespace BootcampManagement
{
    /// <summary>
    /// Interaction logic for RegisterFormWindow.xaml
    /// </summary>
    public partial class RegisterFormWindow : Window
    {
        TB_M_Province tB_M_Province = new TB_M_Province();
        IProvince iProvince = new ProvinceController();
        public RegisterFormWindow()
        {
            InitializeComponent();
            List<TB_M_Province> ProvinceList = iProvince.Get();
            Province_Cmbbox.ItemsSource = ProvinceList;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); 
        }

        private void FirstName_Tbox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Province_Cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
