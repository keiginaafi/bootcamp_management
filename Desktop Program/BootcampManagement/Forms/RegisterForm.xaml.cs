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
    public partial class RegisterForm : Window
    {
        IProvince iProvince = new ProvinceController();
        IRegion iRegion = new RegionController();
        IDistrict iDistrict = new DistrictController();
        IVillage iVillage = new VillageController();
        MyContext myContext = new MyContext();

        public RegisterForm()
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

        private void City_Cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = City_Cmbbox.SelectedValue;
            if (selectedItem != null)
            {
                List<TB_M_District> SubCityList = iDistrict.GetList(Convert.ToInt16(selectedItem));
                SubCity_Cmbbox.ItemsSource = SubCityList;

            }
        }

        private void Province_Cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = Province_Cmbbox.SelectedValue;
            if (selectedItem != null)
            {
                List<TB_M_Region> RegionList = iRegion.GetList(Convert.ToInt16(selectedItem));
                City_Cmbbox.ItemsSource = RegionList;

            }
        }

        private void SubCity_Cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = SubCity_Cmbbox.SelectedValue;
            if (selectedItem != null)
            {
                List<TB_M_Village> VillageList = iVillage.GetList(Convert.ToInt16(selectedItem));
                Village_Cmbbox.ItemsSource = VillageList;
            }
        }
    }
}
