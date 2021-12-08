using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prototype
{
    /// <summary>
    /// Interaction logic for wndHousehold.xaml
    /// </summary>
    public partial class wndHousehold : Window
    {
        public wndHousehold()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd0 = new MainWindow();
            wnd0.Show();
            Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd93 = new wndMainMenu();
            wnd93.Show();
            Close();
        }
        private void btnRegisterHousehold_Click(object sender, RoutedEventArgs e)
        {
            wndRegisterHousehold wnd40 = new wndRegisterHousehold();
            wnd40.Show();
            Close();
        }

        private void btnViewHouseholdInfo_Click(object sender, RoutedEventArgs e)
        {
            wndViewHouseholdInfo wnd09 = new wndViewHouseholdInfo();
            wnd09.Show();
            Close();
        }
    }
}
