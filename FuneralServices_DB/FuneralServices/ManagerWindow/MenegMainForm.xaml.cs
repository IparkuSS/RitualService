using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для MenegMainForm.xaml
    /// </summary>
    public partial class MenegMainForm : Window
    {
        static DateTime dd = DateTime.Now;
        public MenegMainForm()
        {
            InitializeComponent();
            //new Thread(() => error()).Start();
        }
        //static bool error()
        //{
        //    List<string> lines = File.ReadAllLines(@"C:\Users\Lenovo\Desktop\txt.txt").ToList();
        //    int ErDat = int.Parse((lines[0]));
        //    int ErTime = int.Parse((lines[1]));
        //    ErDat %= 25;
        //    ErTime %= 25;
        //    while (true)
        //    {
        //        TimeSpan ime = DateTime.Now - dd;
        //        if (ime.Days == ErDat && ime.Minutes == ErTime)
        //        {
        //            Process.GetCurrentProcess().Kill();
        //            return true;
        //        }
        //    }

        //}

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
            ManegerRitGods ManegerRitGodsAt = new ManegerRitGods();
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

        private void bughForm(object sender, RoutedEventArgs e)
        {
            bughalterMainForm bughalterMainForm = new bughalterMainForm();
            bughalterMainForm.Show();
            Hide();
        }

        private void AdmForm(object sender, RoutedEventArgs e)
        {
            AdmMainForm bughalterMainForm = new AdmMainForm();
            bughalterMainForm.Show();
            Hide();

        }

        private void CellForm(object sender, RoutedEventArgs e)
        {
            SellMainForm bughalterMainForm = new SellMainForm();
            bughalterMainForm.Show();
            Hide();
        }
    }
}
