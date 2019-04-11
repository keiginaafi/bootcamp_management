using BootcampManagement.UserControls;
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

namespace BootcampManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        //string role = "User";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if (role == "User")
            //{
            //    Main_Grid.Children.Clear();
            //    Main_Grid.Children.Add(new User_Dashboard());
            //    ListViewItemThree.Visibility = Visibility.Collapsed;
            //    ListViewItemFour.Visibility = Visibility.Collapsed;
            //    ListViewItemFive.Visibility = Visibility.Collapsed;
            //    ListViewItemSix.Visibility = Visibility.Collapsed;
            //}
            //else if (role == "Trainer")
            //{
            //    Main_Grid.Children.Clear();
            //    Main_Grid.Children.Add(new User_Dashboard());
            //    ListTwo_Txt.Text = "Manage Locker";
            //    ListTwo_Icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.LockOpenOutline;
            //    ListFive_Txt.Text = "Manage Score";
            //}
        }

        private void Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Menu_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //int index = Menu_ListView.SelectedIndex;


            //if (role == "User")
            //{
            //    switch (index)
            //    {
            //        case 1:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new User_Dashboard());
            //            break;
            //        case 2:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new User_CreateCV());
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //else if (role == "Trainer")
            //{
            //    switch (index)
            //    {
            //        case 1:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new User_Dashboard());
            //            break;
            //        case 2:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new Trainer_Locker());
            //            break;
            //        case 3:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new Trainer_AccessCard());
            //            break;
            //        case 4:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new Trainer_Lesson());
            //            break;
            //        case 6:
            //            Main_Grid.Children.Clear();
            //            Main_Grid.Children.Add(new Trainer_Site());
            //            break;

            //        default:
            //            break;
            //    }
            //}
        }

        private void DailyScore_LView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main_Grid.Children.Clear();
            Main_Grid.Children.Add(new Trainer_DailyScore());
        }

        private void WeeklyScore_LView_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Main_Grid.Children.Clear();
            Main_Grid.Children.Add(new Trainer_WeeklyScore());
        }
    }
}

