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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Main_Grid.Children.Clear();
            Main_Grid.Children.Add(new DashboardUserControl());
            Cursor_Grid.Visibility = Visibility.Collapsed;
        }

        private void Close_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Menu_ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = Menu_ListView.SelectedIndex;
            moveCursorMenu(index);

            switch (index)
            {
                case 1:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new DashboardUserControl());
                    break;
                case 2:
                    Main_Grid.Children.Clear();
                    Main_Grid.Children.Add(new CreateCVUserControl());
                    break;
                default:
                    break;
            }
        }

        void moveCursorMenu(int index)
        {
            Slide_TransitionContent.OnApplyTemplate();
            if (index == 0)
            {
                Cursor_Grid.Visibility = Visibility.Collapsed;
            }
            else
            {
                Cursor_Grid.Visibility = Visibility.Visible;
                Cursor_Grid.Margin = new Thickness(0, 100 + (50 * (index - 1)), 0, 0);
            }
        }
    }
}
