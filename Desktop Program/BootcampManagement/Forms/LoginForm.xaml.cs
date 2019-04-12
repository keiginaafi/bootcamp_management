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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        MyContext myContext = new MyContext();
        MD5 md5Hash = MD5.Create();

        public LoginForm()
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Register_Btn_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm RegForm = new RegisterForm();
            RegForm.Show();
        }

        private void Login_Btn_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(UsernameLogin_Tbox.Text) || String.IsNullOrWhiteSpace(PasswordLogin_Pbox.Password))
            {
                MessageBox.Show("Fill Username and Password");
                UsernameLogin_Tbox.Background = new SolidColorBrush(Colors.Red);
                PasswordLogin_Pbox.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                var username = UsernameLogin_Tbox.Text;
                var password = PasswordLogin_Pbox.Password;
                var hashedPassword = getMD5Hash(md5Hash, password);
                var getAccount = myContext.TB_M_Accounts.Include("TB_M_Roles").SingleOrDefault(x => x.Username == username && x.Password == hashedPassword);
                if (getAccount == null)
                {
                    MessageBox.Show("Invalid Username or Password");
                    UsernameLogin_Tbox.Background = new SolidColorBrush(Colors.Red);
                    PasswordLogin_Pbox.Background = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    switch (getAccount.TB_M_Roles.Name)
                    {
                        case "User":
                            Dashboard dashboard = new Dashboard(getAccount.TB_M_Roles.Name);
                            UsernameLogin_Tbox.Clear();
                            dashboard.Show();
                            this.Close();
                            break;
                        case "Member":
                            Dashboard board = new Dashboard(getAccount.TB_M_Roles.Name);
                            UsernameLogin_Tbox.Clear();
                            board.Show();
                            this.Close();
                            break;
                        case "Trainer":
                            Dashboard dash = new Dashboard(getAccount.TB_M_Roles.Name);
                            UsernameLogin_Tbox.Clear();
                            dash.Show();
                            this.Close();
                            break;
                        case "HR":
                            Dashboard shboard = new Dashboard(getAccount.TB_M_Roles.Name);
                            UsernameLogin_Tbox.Clear();
                            shboard.Show();
                            this.Close();
                            break;
                        case "Manager":
                            Dashboard dashbo = new Dashboard(getAccount.TB_M_Roles.Name);
                            UsernameLogin_Tbox.Clear();
                            dashbo.Show();
                            this.Close();
                            break;
                        case "Admin":
                            Dashboard ashboa = new Dashboard(getAccount.TB_M_Roles.Name);
                            ashboa.Show();
                            this.Close();
                            break;
                        default:
                            MessageBox.Show("Invalid Username or Password");
                            break;
                    }
                }
            }
            
        }

        static string getMD5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(ASCIIEncoding.ASCII.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMD5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
