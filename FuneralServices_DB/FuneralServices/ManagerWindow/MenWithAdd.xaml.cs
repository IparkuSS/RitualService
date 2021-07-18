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
    /// Логика взаимодействия для MenWithAdd.xaml
    /// </summary>
    public partial class MenWithAdd : Window
    {
        public Wreath WreathA { get; private set; }
        public MenWithAdd(Wreath s)
        {
            InitializeComponent();
            WreathA = s;
            this.DataContext = WreathA;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string classWre = classWree.Text.Trim();
            string typeWrea = typeWreaa.Text.Trim();
            string skladKol = skladKoll.Text.Trim();
            //string solid = solidd.Text;

            int res;
           // decimal resQ;
            bool isInt = Int32.TryParse(classWre, out res);
            bool isIntTwo = Int32.TryParse(typeWrea, out res);
            bool isIntThree = Int32.TryParse(skladKol, out res);
            //bool isIntfour = decimal.TryParse(solid, out resQ);

            if (classWre.Length < 3 || isInt == true)
            {
                classWree.ToolTip = "это поле введено не корректно";
                classWree.Background = Brushes.Red;

            }
            else if (typeWrea.Length < 3 || isIntTwo == true)
            {
                typeWreaa.ToolTip = "это поле введено не корректно";
                typeWreaa.Background = Brushes.Red;
            }
            else if (skladKol.Length < 3 || isIntThree == true)
            {
                skladKoll.ToolTip = "это поле введено не корректно";
                skladKoll.Background = Brushes.Red;
            }
            //else if ( isIntfour == false)
            //{
            //    solidd.ToolTip = "это поле введено не корректно";
            //    solidd.Background = Brushes.Red;
            //}





            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenCros MenCrosA = new MenCros();
            MenCrosA.Show();
            Hide();
        }
    }
}
