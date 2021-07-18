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
    /// Логика взаимодействия для MenegerOrderAdd.xaml
    /// </summary>
    public partial class MenegerOrderAdd : Window
    {
        public Order order { get; private set; }
        public MenegerOrderAdd(Order s)
        {
            InitializeComponent();
            order = s;
            this.DataContext = order;
        }
       private void myCmb_Loadeddd(object sender, SelectionChangedEventArgs e)
        {
            
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            string flo = floO.Text.Trim();
            string adress = adressO.Text.Trim();
            string SolidKop = SolidKopO.Text;
           
            int res;
            decimal resQ;
            bool isInt = Int32.TryParse(flo, out res);
            bool isIntTwo = Int32.TryParse(adress, out res);
            bool isIntThree = decimal.TryParse(SolidKop, out resQ);
          
            if (flo.Length != 3 || isInt == true)
            {
                floO.ToolTip = "это поле введено не корректно";
                floO.Background = Brushes.Red;

            }
            else if (adress.Length < 5 || isIntTwo == true)
            {
                adressO.ToolTip = "это поле введено не корректно";
                adressO.Background = Brushes.Red;
            }
            else if (isIntThree == false)
            {
                SolidKopO.ToolTip = "это поле введено не корректно";
                SolidKopO.Background = Brushes.Red;
            }
            

            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenegOrder MenegOrderAt = new MenegOrder();
            MenegOrderAt.Show();
            Hide();
        }

        private void myCmb_Loadeddd(object sender, RoutedEventArgs e)
        {
            List<string> listTemp = new List<string>();
            //List<user> listCustC;
            ComboBox cmb = (ComboBox)sender;

            listTemp.Add("Кремация");
            listTemp.Add("Традиционные похороны");
            listTemp.Add("Прямой захоронение");
            cmb.ItemsSource = listTemp;
        }
    }
}
