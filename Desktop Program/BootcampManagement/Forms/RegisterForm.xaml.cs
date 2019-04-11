using BootcampManagement.Controller;
using BootcampManagement.Interface;
using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        ISubDistrict iSubDistrict = new SubDistrictController();
        IDistrict iDistrict = new DistrictController();
        IVillage iVillage = new VillageController();
        IReligion iReligion = new ReligionController();
        IUser iUser = new UserController();
        IAccount iAccount = new AccountController();

        MyContext myContext = new MyContext();

        TB_M_User tB_M_User = new TB_M_User();
        TB_M_Account tB_M_Account = new TB_M_Account();

        public RegisterForm()
        {
            InitializeComponent();
            //ComboBoxProvince
            List<TB_M_Province> ProvinceList = iProvince.Get();
            Province_Cmbbox.ItemsSource = ProvinceList;

            //ComboBoxReligion
            List<TB_M_Religion> ReligionList = iReligion.Get();
            Religion_Cmbbox.ItemsSource = ReligionList;
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
                List<TB_M_Sub_District> SubCityList = iSubDistrict.GetList(Convert.ToInt16(selectedItem));
                SubCity_Cmbbox.ItemsSource = SubCityList;

            }
        }

        private void Province_Cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object selectedItem = Province_Cmbbox.SelectedValue;
            if (selectedItem != null)
            {
                List<TB_M_District> RegionList = iDistrict.GetList(Convert.ToInt16(selectedItem));
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

        private void Register_Btn_Click(object sender, RoutedEventArgs e)
        {
            //int a = Convert.ToInt16(Supp_Cbx.SelectedValue);
            //var b = iSupplier.Get(a);
            tB_M_User.First_name = FirstName_Tbox.Text;
            tB_M_User.Last_name = LastName_Tbox.Text;
            tB_M_User.Date_of_birth = Convert.ToDateTime(DateOfBirth_Dtp.Text);
            //Get Combo Box Status
            ComboBoxItem typeItem = (ComboBoxItem)Status_Cmbbox.SelectedItem;
            string status = typeItem.Content.ToString();
            bool statuss = false;
            if(status == "Married")
            {
                statuss = true;
            }
            tB_M_User.IsMarried = statuss;
            //End Combo Box Status
            ComboBoxItem Gender = (ComboBoxItem)Gender_Cmbbox.SelectedItem;
            tB_M_User.Gender = Gender.Content.ToString();
            tB_M_User.TB_M_Religions = myContext.TB_M_Religions.Find(Convert.ToInt16(Religion_Cmbbox.SelectedValue));
            tB_M_User.Email = Email_Tbox.Text;
            tB_M_User.Contact = Contact_Tbox.Text;
            tB_M_User.Street_address = StreetAddress_Tbox.Text;
            tB_M_User.TB_M_Villages = myContext.TB_M_Villages.Find(Convert.ToInt16(Village_Cmbbox.SelectedValue));

            //var result = iUser.Insert(tB_M_User);
            myContext.TB_M_Users.Add(tB_M_User);
            myContext.SaveChanges();

            tB_M_Account.Password = MD5Hash(Password_Pbox.Password);
            tB_M_Account.id = tB_M_User.id;
            tB_M_Account.TB_M_Roles = myContext.TB_M_Roles.Find(1);
            tB_M_Account.Username = Email_Tbox.Text;

            myContext.TB_M_Accounts.Add(tB_M_Account);
            myContext.SaveChanges();

            //var result1 = iAccount.Insert(tB_M_Account);


            //if (result)
            //{
            //    MessageBox.Show("Success");
            //    //SupplierName_Txt.Text = "";
            //    //Id_Txt.Text = "";
            //    //Item_Dgv.ItemsSource = iItem.Get();
            //}
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
