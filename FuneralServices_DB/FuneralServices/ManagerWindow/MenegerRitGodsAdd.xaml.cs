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
    /// Логика взаимодействия для MenegerRitGodsAdd.xaml
    /// </summary>
    public partial class MenegerRitGodsAdd : Window
    {
        public RitualGod ritualGod { get; private set; }
        public MenegerRitGodsAdd(RitualGod s)
        {
            InitializeComponent();
            ritualGod = s;
            this.DataContext = ritualGod;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            ManegerRitGods ManegerRitGodsAt = new ManegerRitGods();
            ManegerRitGodsAt.Show();
            Hide();
        }
    }
}
