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
    /// Логика взаимодействия для BughCrossAdd.xaml
    /// </summary>
    public partial class BughCrossAdd : Window
    {
        public Crosse CoffinAA { get; private set; }
        public BughCrossAdd(Crosse s)
        {
            InitializeComponent();
            CoffinAA = s;
            this.DataContext = CoffinAA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            string SolidCofIn = solidCofIn.Text;
            double resQ;

            bool isIntThree = double.TryParse(SolidCofIn, out resQ);

            if (SolidCofIn.Length < 1 || isIntThree == false)
            {
                solidCofIn.ToolTip = "это поле введено не корректно";
                solidCofIn.Background = Brushes.Red;
            }

            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            BughRitServ MenCofa = new BughRitServ();
            MenCofa.Show();
            Hide();
        }
    }
}
