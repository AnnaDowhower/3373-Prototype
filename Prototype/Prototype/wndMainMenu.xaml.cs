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
    /// Interaction logic for wndMainMenu.xaml
    /// </summary>
    public partial class wndMainMenu : Window
    {
        public wndMainMenu()
        {
            InitializeComponent();
        }

        private void btnHousehold_Click(object sender, RoutedEventArgs e)
        {
            wndHousehold wnd2 = new wndHousehold();
            wnd2.Show();
        }

        private void btnViewReports_Click(object sender, RoutedEventArgs e)
        {
            wndViewReports wnd5 = new wndViewReports();
            wnd5.Show();
        }

        private void btnCeremonies_Click(object sender, RoutedEventArgs e)
        {
            wndCeremonies wnd3 = new wndCeremonies();
            wnd3.Show();
        }

        private void btnFinancials_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd4 = new wndMainMenu();
            wnd4.Show();
        }
    }
}
