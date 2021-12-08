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
    /// Interaction logic for wndViewHouseholdInfo.xaml
    /// </summary>
    public partial class wndViewHouseholdInfo : Window
    {
        private List<Household> households = new List<Household>();
        public wndViewHouseholdInfo()
        {
            InitializeComponent();

            Household house1 = new Household("113456","Houston", "2210 Elk Springs Drive, McKinney, TX, 75071", "12345@boomer.com");
            Household house2 = new Household("213475","Dowhower", "4500 Boyd St, Norman, OK, 205204", "hello123@aol.com");
            Household house3 = new Household("259724","Smith", "1823 Sour Melon Way Moore, OK, 73069", "sooner@boomer.com");

            lstHouse.Items.Add(house1);
            lstHouse.Items.Add(house2);
            lstHouse.Items.Add(house3);
            households.Add(house1);
            households.Add(house2);
            households.Add(house3);

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string householdName = nameHouse.Text;


        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            wndHousehold wnd1 = new wndHousehold();
            wnd1.Show();
            Close();
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            wndMainMenu wnd1 = new wndMainMenu();
            wnd1.Show();
            Close();
        }
    }
}
