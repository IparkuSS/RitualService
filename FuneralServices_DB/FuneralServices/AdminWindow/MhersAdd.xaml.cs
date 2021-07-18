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
    public partial class MhersAdd : Window
    {
        public Hearse hearseA { get; private set; }
        public MhersAdd(Hearse s)
        {
            InitializeComponent();

            hearseA = s;
            this.DataContext = hearseA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {

            string MaterCofIn = materCofIn.Text.Trim();
            //string ClassCofIn = classCofIn.Text.Trim();
            int res;
            decimal resQ;
            bool isInt = Int32.TryParse(MaterCofIn, out res);
            //bool isIntThree = decimal.TryParse(ClassCofIn, out resQ);
            if (MaterCofIn.Length < 2 || isInt == true)
            {
                materCofIn.ToolTip = "это поле введено не корректно";
                materCofIn.Background = Brushes.Red;

            }
            //else if (ClassCofIn.Length < 1 || isIntThree == false)
            //{
            //    classCofIn.ToolTip = "это поле введено не корректно";
            //    classCofIn.Background = Brushes.Red;
            //}
          

            else this.DialogResult = true;




           
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MHers MHersAT = new MHers();
            MHersAT.Show();
            Hide();
        }
    }
}
