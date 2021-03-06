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
    /// Interaction logic for wndUpcomingCeremonies.xaml
    /// </summary>
    public partial class wndUpcomingCeremonies : Window
    {
        public wndUpcomingCeremonies()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            wndCeremonies wnd1 = new wndCeremonies();
            wnd1.Show();
            Close();
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
    }
}
