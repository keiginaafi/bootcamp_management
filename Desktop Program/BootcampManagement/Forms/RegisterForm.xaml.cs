using BootcampManagement.Controller;
using BootcampManagement.Interface;
using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

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
            SqlDataReader reader;
            SqlCommand command;
            string query;
            string conn = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=BootcampManagement; Integrated Security=true";
            SqlConnection myConnection = new SqlConnection(conn);
            //int a = Convert.ToInt16(Supp_Cbx.SelectedValue);
            //var b = iSupplier.Get(a);
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool IsEmailValid = email.IsMatch(Email_Tbox.Text);
            

            tB_M_User.First_name = FirstName_Tbox.Text;
            if (FirstName_Tbox.Text == "")
            {
                FirstName_Tbox.Focus();
            }
            else 
            {
                if (LastName_Tbox.Text == "")
                {
                    LastName_Tbox.Focus();
                }
                else
                {
                    tB_M_User.Last_name = LastName_Tbox.Text;
                    if (DateOfBirth_Dtp.Text == "")
                    {
                        DateOfBirth_Dtp.Focus();
                    }
                    else
                    {
                        tB_M_User.Date_of_birth = Convert.ToDateTime(DateOfBirth_Dtp.Text);
                        if (Status_Cmbbox.Text == "")
                        {
                            Status_Cmbbox.Focus();
                        }
                        else
                        {
                            //Get Combo Box Status
                            ComboBoxItem typeItem = (ComboBoxItem)Status_Cmbbox.SelectedItem;
                            string status = typeItem.Content.ToString();
                            bool statuss = false;
                            if (status == "Married")
                            {
                                statuss = true;
                            }
                            tB_M_User.IsMarried = statuss;
                            //End Combo Box Status
                            if(Gender_Cmbbox.Text == "")
                            {
                                Gender_Cmbbox.Focus();
                            }
                            else
                            {
                                ComboBoxItem Gender = (ComboBoxItem)Gender_Cmbbox.SelectedItem;
                                tB_M_User.Gender = Gender.Content.ToString();
                                if (Religion_Cmbbox.Text == "")
                                {
                                    Religion_Cmbbox.Focus();
                                }
                                else
                                {
                                    tB_M_User.TB_M_Religions = myContext.TB_M_Religions.Find(Convert.ToInt16(Religion_Cmbbox.SelectedValue));
                                    if(Email_Tbox.Text == "")
                                    {
                                        Email_Tbox.Focus();
                                    }
                                    else
                                    {
                                        tB_M_User.Email = Email_Tbox.Text;
                                        if(Contact_Tbox.Text == "")
                                        {
                                            Contact_Tbox.Focus();
                                        }
                                        else
                                        {
                                            tB_M_User.Contact = Contact_Tbox.Text;
                                            if (StreetAddress_Tbox.Text == "")
                                            {
                                                StreetAddress_Tbox.Focus();
                                            }
                                            else
                                            {
                                                tB_M_User.Street_address = StreetAddress_Tbox.Text;
                                                if (Village_Cmbbox.Text == "")
                                                {
                                                    Village_Cmbbox.Focus();
                                                }
                                                else
                                                {
                                                    //var validEmail = myContext.TB_M_Accounts.SingleOrDefault(x => x.Username == (Email_Tbox.Text));
                                                    tB_M_User.TB_M_Villages = myContext.TB_M_Villages.Find(Convert.ToInt16(Village_Cmbbox.SelectedValue));
                                                    if (!IsEmailValid)
                                                    {

                                                        MessageBox.Show("Please enter a valid email");
                                                        Email_Tbox.Focus();
                                                        //Email_Tbox.Background = Brushes.Red;
                                                    }
                                                    else if(ConfirmPassword_Pbox.Password != Password_Pbox.Password)
                                                    {
                                                        MessageBox.Show("Password Not Match");
                                                        ConfirmPassword_Pbox.Focus();
                                                    }
                                                    else if(TermOfUse_Check.IsChecked==false)
                                                    {

                                                        MessageBox.Show("Please Accept Term Of Use & Privacy Police");
                                                    }
                                                    //else if(validEmail != null)
                                                    //{
                                                    //    MessageBox.Show("Email is already used");
                                                    //}
                                                    else
                                                    {
                                                        //var result = iUser.Insert(tB_M_User);
                                                        myContext.TB_M_Users.Add(tB_M_User);
                                                        var result = myContext.SaveChanges();

                                                        tB_M_Account.Password = MD5Hash(Password_Pbox.Password);
                                                        tB_M_Account.id = tB_M_User.id;
                                                        tB_M_Account.TB_M_Roles = myContext.TB_M_Roles.Find(1);
                                                        tB_M_Account.Username = Email_Tbox.Text;

                                                        myContext.TB_M_Accounts.Add(tB_M_Account);
                                                        //var result1 = myContext.SaveChanges();

                                                        query = "insert into TB_M_Account " +
                                                        "(id,Username, Password, IsDelete, CreateDate, TB_M_Roles_id) values " +
                                                        "('" + tB_M_Account.id + "', " +
                                                        "'" + tB_M_Account.Username + "', " +
                                                        "'" + tB_M_Account.Password + "', " +
                                                        "'" + 0 + "', " +
                                                        "'" + DateTimeOffset.UtcNow.ToLocalTime() + "', " +
                                                        "'" + 1 + "')";

                                                        command = new SqlCommand(query, myConnection);
                                                        myConnection.Open();
                                                        reader = command.ExecuteReader();
                                                        if (reader == null)
                                                        {
                                                            MessageBox.Show("Insert Successfully");
                                                            myConnection.Close();
                                                        }
                                                        else
                                                        {
                                                            myConnection.Close();
                                                        }

                                                        //var getData = myContext.TB_M_Accounts.SingleOrDefault(x => x.Username == tB_M_Account.Username);
                                                        //getData.id = tB_M_User.id;
                                                        //var result2 = myContext.SaveChanges();

                                                        if (result > 0)
                                                        {
                                                            MessageBox.Show("Register Success");
                                                            FirstName_Tbox.Clear();
                                                            LastName_Tbox.Clear();
                                                            DateOfBirth_Dtp.Text = "";
                                                            Status_Cmbbox.Text = "";
                                                            Gender_Cmbbox.Text = "";
                                                            Religion_Cmbbox.Text = "";
                                                            Email_Tbox.Clear();
                                                            Contact_Tbox.Clear();
                                                            StreetAddress_Tbox.Clear();
                                                            Province_Cmbbox.Text = "";
                                                            City_Cmbbox.Text = "";
                                                            SubCity_Cmbbox.Text = "";
                                                            Village_Cmbbox.Text = "";
                                                            Password_Pbox.Clear();
                                                            ConfirmPassword_Pbox.Clear();
                                                            TermOfUse_Check.IsChecked = false;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Error, Please Try Again");
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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

        //private void DateOfBirth_Dtp_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    Regex regex = new Regex("^[0-9]*$");
        //    bool isValid = regex.IsMatch(DateOfBirth_Dtp.Text);
        //    if (!isValid)
        //    {
        //        //SecondNumber_Txt.Text = "";
        //        DateOfBirth_Dtp.Background = Brushes.Red;

        //    }
        //    else
        //    {
        //        DateOfBirth_Dtp.Background = Brushes.White;
        //    }
        //}

        private void DateOfBirth_Dtp_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]"); //regex that matches allowed text
            e.Handled = regex.IsMatch(e.Text);

        }

        private void DateOfBirth_Dtp_KeyUp(object sender, KeyEventArgs e)
        {
            DatePicker dp = (DatePicker)sender;
            string justNumbers = new String(dp.Text.Where(Char.IsDigit).ToArray());
            if (justNumbers.Length == 8)
            {
                string newDate = justNumbers.Insert(2, "/").Insert(5, "/");
                try
                {
                    dp.SelectedDate = DateTime.Parse(newDate);
                }
                catch (Exception ex)
                {
                    dp.Text = "";
                }
            }
        }

        private void Contact_Tbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]"); //regex that matches allowed text
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Cancel_Btn_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm regis = new RegisterForm();
            //this.Close(); ((TextBox)ctl).Text = "";
            //MainPanel.Children.Clear();
            this.Close();
        }

        private void Email_Tbox_KeyUp(object sender, KeyEventArgs e)
        {
            var validEmail = myContext.TB_M_Accounts.SingleOrDefault(x => x.Username == (Email_Tbox.Text));
            if (validEmail != null)
            {
                //MessageBox.Show("Email Sudah Ada Bosku");
                EmailValid_Txb.Text = "*Email is already used";
                EmailValid_Txb.Foreground = Brushes.Red;
                Register_Btn.IsEnabled = false;
            }
            else
            {
                EmailValid_Txb.Text = "*Email available";
                EmailValid_Txb.Foreground = Brushes.Green;
                Register_Btn.IsEnabled = true;
            }
        }
    }
}
