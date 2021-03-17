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

namespace DriversApp
{
    /// <summary>
    /// Логика взаимодействия для driver.xaml
    /// </summary>
    public partial class Driver : Page
    {
        public Driver()
        {
            InitializeComponent();
            DGridDrivers.ItemsSource = DriversBaseEntities.GetContext().Drivers.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
