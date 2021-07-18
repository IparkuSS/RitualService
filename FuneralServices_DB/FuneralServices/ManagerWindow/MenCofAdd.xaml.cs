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
    /// Логика взаимодействия для MenCofAdd.xaml
    /// </summary>
    public partial class MenCofAdd : Window
    {
        public Coffin CoffinA { get; private set; }
        public MenCofAdd(Coffin s)
        {
            InitializeComponent();
            CoffinA = s;
            this.DataContext = CoffinA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            string MaterCofIn = materCofIn.Text.Trim();
            string ClassCofIn = classCofIn.Text.Trim();
            //string SolidCofIn = solidCofIn.Text;
            string CountSkIn = countSkIn.Text;
            int res;
            double resQ;
            bool isInt = Int32.TryParse(MaterCofIn ,out res);
            bool isIntTwo = Int32.TryParse(ClassCofIn, out res);
            //bool isIntThree = double.TryParse(SolidCofIn, out resQ);
            bool isIntFour = Int32.TryParse(CountSkIn, out res);
            if (MaterCofIn.Length < 4 || isInt == true)
            {
                materCofIn.ToolTip = "это поле введено не корректно";
                materCofIn.Background = Brushes.Red;

            }
            else if (ClassCofIn.Length < 4 || isIntTwo == true)
            {
                classCofIn.ToolTip = "это поле введено не корректно";
                classCofIn.Background = Brushes.Red;
            }
            //else if (SolidCofIn.Length == 0 || isIntThree == false)
            //{
            //    solidCofIn.ToolTip = "это поле введено не корректно";
            //    solidCofIn.Background = Brushes.Red;
            //}
            else if (CountSkIn.Length == 0 || isIntFour == false)
            {
                countSkIn.ToolTip = "это поле введено не корректно";
                countSkIn.Background = Brushes.Red;
            }

            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenCof MenCofa = new MenCof();
            MenCofa.Show();
            Hide();
        }
    }
}
