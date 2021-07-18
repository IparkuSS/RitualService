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
    /// Логика взаимодействия для bughalterMainForm.xaml
    /// </summary>
    public partial class bughalterMainForm : Window
    {
        public bughalterMainForm()
        {
            InitializeComponent();
        }

        private void MenMaFoOrd(object sender, RoutedEventArgs e)
        {
            BughRItgod MainWindowAt = new BughRItgod();
            MainWindowAt.Show();
            Hide();
        }

        private void MenMaFoFunSer(object sender, RoutedEventArgs e)
        {
            BughRitServ MainWindowAt = new BughRitServ();
            MainWindowAt.Show();
            Hide();
        }

        private void MenMaFoOut(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindowAt = new MainWindow();
            MainWindowAt.Show();
            Hide();
        }

        private void meneger(object sender, RoutedEventArgs e)
        {
            MenegMainForm MainWindowAt = new MenegMainForm();
            MainWindowAt.Show();
            Hide();
        }
    }
}
