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
    /// Логика взаимодействия для MenMonumAdd.xaml
    /// </summary>
    public partial class MenMonumAdd : Window
    {
        public Monument monumentAt { get; private set; }
        public MenMonumAdd(Monument s)
        {
            InitializeComponent();
            monumentAt = s;
            this.DataContext = monumentAt;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string Orderr = order.Text.Trim();
            string NumPhond = numPhond.Text.Trim();
            //string SolidCofIn = solidCofIn.Text;

            int res;
          //  decimal resQ;
            bool isInt = Int32.TryParse(Orderr, out res);
            bool isIntTwo = Int32.TryParse(NumPhond, out res);
            //bool isIntThree = decimal.TryParse(SolidCofIn, out resQ);
            if (Orderr.Length < 4 || isInt == true)
            {
                order.ToolTip = "это поле введено не корректно";
                order.Background = Brushes.Red;

            }
            else if (NumPhond.Length !=9 || isIntTwo == false)
            {
                numPhond.ToolTip = "это поле введено не корректно";
                numPhond.Background = Brushes.Red;
            }
            //else if (SolidCofIn.Length == 0 || isIntThree == false)
            //{
            //    solidCofIn.ToolTip = "это поле введено не корректно";
            //    solidCofIn.Background = Brushes.Red;
            //}





            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenMonumentForm MenMonumentFormaT = new MenMonumentForm();
            MenMonumentFormaT.Show();
            Hide();
        }
    }
}
