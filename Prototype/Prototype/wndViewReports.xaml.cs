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
    /// Interaction logic for wndViewReports.xaml
    /// </summary>
    public partial class wndViewReports : Window
    {
        public wndViewReports()
        {
            InitializeComponent();
            fillCeremonyReports();
            fillFinancialReports();
            fillContributionReports();
            imgReport.Visibility = Visibility.Hidden;
            //oneSelection();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wnd0 = new MainWindow();
            wnd0.Show();
            Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd1 = new wndMainMenu();
            wnd1.Show();
            Close();
        }
        private void fillCeremonyReports()
        {
            cboCeremony.Items.Add("        ");
            for (int year = 2015; year < 2021; year++)
            {
                cboCeremony.Items.Add($"January {year}");
                cboCeremony.Items.Add($"February {year}");
                cboCeremony.Items.Add($"March {year}");
                cboCeremony.Items.Add($"April {year}");
                cboCeremony.Items.Add($"May {year}");
                cboCeremony.Items.Add($"June {year}");
                cboCeremony.Items.Add($"July {year}");
                cboCeremony.Items.Add($"August {year}");
                cboCeremony.Items.Add($"September {year}");
                cboCeremony.Items.Add($"October {year}");
                cboCeremony.Items.Add($"November {year}");
                cboCeremony.Items.Add($"December {year}");
                cboCeremony.Items.Add("----------------");
            }
        }

        private void fillFinancialReports()
        {
            cboFinancial.Items.Add("        ");
            for (int year = 2015; year < 2021; year++)
            {
                cboFinancial.Items.Add($"January {year}");
                cboFinancial.Items.Add($"February {year}");
                cboFinancial.Items.Add($"March {year}");
                cboFinancial.Items.Add($"April {year}");
                cboFinancial.Items.Add($"May {year}");
                cboFinancial.Items.Add($"June {year}");
                cboFinancial.Items.Add($"July {year}");
                cboFinancial.Items.Add($"August {year}");
                cboFinancial.Items.Add($"September {year}");
                cboFinancial.Items.Add($"October {year}");
                cboFinancial.Items.Add($"November {year}");
                cboFinancial.Items.Add($"December {year}");
                cboFinancial.Items.Add("----------------");
            }
        }
        private void fillContributionReports()
        {
            cboContribution.Items.Add("        ");
            for (int year = 2015; year < 2021; year++)
            {
                cboContribution.Items.Add(year);
            }
        }

        private void cboFinancial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            imgReport.Visibility = Visibility.Visible;
            if (cboFinancial.SelectedIndex == 0)
            {
                imgReport.Visibility = Visibility.Hidden;
            }
        }
        /*private void oneSelection()
        {
            if (cboCeremony.SelectedIndex != 0)
            {
                cboContribution.SelectedIndex = 0;
                cboFinancial.SelectedIndex = 0;
            }
            if (cboContribution.SelectedIndex != 0)
            {
                cboCeremony.SelectedIndex = 0;
                cboFinancial.SelectedIndex = 0;
            }
            if (cboFinancial.SelectedIndex != 0)
            {
                cboContribution.SelectedIndex = 0;
                cboCeremony.SelectedIndex = 0;
            }
        }*/
    }
}
