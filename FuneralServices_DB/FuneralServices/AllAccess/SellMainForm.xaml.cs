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
    /// Логика взаимодействия для SellMainForm.xaml
    /// </summary>
    public partial class SellMainForm : Window
    {
        public SellMainForm()
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
            MenCof MenegOrderAt = new MenCof();
            MenegOrderAt.Show();
            Hide();
        }
        private void MenMaFoRitGo(object sender, RoutedEventArgs e)
        {
            ManegerRitGods ManegerRitGodsAt = new ManegerRitGods();
            ManegerRitGodsAt.Show();
            Hide();
        }
        private void MenMaFoCust(object sender, RoutedEventArgs e)
        {
            MenWith MenegerCustomerAtt = new MenWith();
            MenegerCustomerAtt.Show();
            Hide();
        }
        private void MenMaFoFunSer(object sender, RoutedEventArgs e)
        {
            MenCros MenegerFunrServicAt = new MenCros();
            MenegerFunrServicAt.Show();
            Hide();
        }

        private void Meneger(object sender, RoutedEventArgs e)
        {
            MenegMainForm MenegerFunrServicAt = new MenegMainForm();
            MenegerFunrServicAt.Show();
            Hide();
        }
    }
}
    

