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
    /// Логика взаимодействия для MtheFunAdd.xaml
    /// </summary>
    public partial class MtheFunAdd : Window
    {
        public TheFuneral TheFuneralA { get; private set; }
        public MtheFunAdd(TheFuneral s)
        {
            InitializeComponent();
            TheFuneralA = s;
            this.DataContext = TheFuneralA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string Org = orga.Text.Trim();
            string num= numb.Text.Trim();
            //string SolidCofIn = solidCofIn.Text;
            int res;
            decimal resQ;
            bool isInt = Int32.TryParse(Org, out res);
            bool isIntTwo = Int32.TryParse(Org, out res);
            //bool isIntThree = decimal.TryParse(SolidCofIn, out resQ);
          
            if (Org.Length < 4 || isInt == true)
            {
                orga.ToolTip = "это поле введено не корректно";
                orga.Background = Brushes.Red;

            }
            else if (num.Length != 9 || isIntTwo == true)
            {
                numb.ToolTip = "это поле введено не корректно";
                numb.Background = Brushes.Red;
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
            MtheFun MtheFuna = new MtheFun();
            MtheFuna.Show();
            Hide();
        }
    }
}
