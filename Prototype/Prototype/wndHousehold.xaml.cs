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

        private void btnRegisterHousehold_Click(object sender, RoutedEventArgs e)
        {
            wndRegisterHousehold wnd21 = new wndRegisterHousehold();
            wnd21.Show();
        }

        private void btnViewHouseholdInfo_Click(object sender, RoutedEventArgs e)
        {
            wndViewHouseholdInfo wnd22 = new wndViewHouseholdInfo();
            wnd22.Show();
        }
    }
}
