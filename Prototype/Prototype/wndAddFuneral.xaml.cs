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
    /// Interaction logic for wndAddFuneral.xaml
    /// </summary>
    public partial class wndAddFuneral : Window
    {
        public wndAddFuneral()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            wndAddCeremony wnd1 = new wndAddCeremony();
            wnd1.Show();
            Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd1 = new wndMainMenu();
            wnd1.Show();
            Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd0 = new MainWindow();
            wnd0.Show();
            Close();
        }
    }
}
