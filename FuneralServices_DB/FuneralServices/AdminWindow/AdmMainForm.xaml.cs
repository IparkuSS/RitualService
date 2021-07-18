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
using System.Windows.Shapes;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для AdmMainForm.xaml
    /// </summary>
    public partial class AdmMainForm : Window
    {
        public AdmMainForm()
        {
            InitializeComponent();
        }
        private void MenMaFoOut(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindowAt = new MainWindow();
            MainWindowAt.Show();
            Hide();
        }
        private void MenMaFoOrd(object sender, RoutedEventArgs e)
        {
            MenegOrder MenegOrderAt = new MenegOrder();
            MenegOrderAt.Show();
            Hide();
        }
        private void MenMaFoRitGo(object sender, RoutedEventArgs e)
        {
            ADMUsersFrom ManegerRitGodsAt = new ADMUsersFrom();
            ManegerRitGodsAt.Show();
            Hide();
        }
        private void MenMaFoCust(object sender, RoutedEventArgs e)
        {
            MenegerCustomer MenegerCustomerAtt = new MenegerCustomer();
            MenegerCustomerAtt.Show();
            Hide();
        }
        private void MenMaFoFunSer(object sender, RoutedEventArgs e)
        {
            MenegerFunrServic MenegerFunrServicAt = new MenegerFunrServic();
            MenegerFunrServicAt.Show();
            Hide();
        }

        private void meneger(object sender, RoutedEventArgs e)
        {
            MenegMainForm MenegerFunrServicAt = new MenegMainForm();
            MenegerFunrServicAt.Show();
            Hide();
        }
    }
}
