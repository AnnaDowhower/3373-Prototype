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
    /// Interaction logic for wndAddCeremony.xaml
    /// </summary>
    public partial class wndAddCeremony : Window
    {
        public wndAddCeremony()
        {
            InitializeComponent();
        }


        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd93 = new wndMainMenu();
            wnd93.Show();
            Close();
        }

        private void btnWdg_Click(object sender, RoutedEventArgs e)
        {
            wndAddWedding wnd1 = new wndAddWedding();
            wnd1.Show();
            Close();
        }

        private void btnBpt_Click(object sender, RoutedEventArgs e)
        {
            wndAddBaptism wnd2 = new wndAddBaptism();
            wnd2.Show();
            Close();
        }

        private void btnFnl_Click(object sender, RoutedEventArgs e)
        {
            wndAddFuneral wnd3 = new wndAddFuneral();
            wnd3.Show();
            Close();
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
    }
}
