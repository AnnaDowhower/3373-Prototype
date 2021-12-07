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
    /// Interaction logic for wndRegisterHousehold.xaml
    /// </summary>
    public partial class wndRegisterHousehold : Window
    {
        public wndRegisterHousehold()
        {
            InitializeComponent();
        }

        private void btnAddMember_Click(object sender, RoutedEventArgs e)
        {
            wndAddMember wnd211 = new wndAddMember();
            wnd211.Show();
        }
    }
}
