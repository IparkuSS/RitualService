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
    /// Логика взаимодействия для MenegerCustomerAdd.xaml
    /// </summary>
    public partial class MenegerCustomerAdd : Window
    {
        public Customer Customer { get; private set; }
        public MenegerCustomerAdd(Customer c)
        {
            InitializeComponent();
            Customer = c;
            this.DataContext = Customer;
        }
        private void Accept_Click(object sender, RoutedEventArgs e)
        {



            string namEO = nameO.Text.Trim();
            string surNamEO = surNameO.Text.Trim();
            string parTO = partO.Text;
            string phoneNumbeRO = phoneNumberO.Text;
            string addresSO = addresO.Text;
            int res;
          
            bool isInt = Int32.TryParse(namEO, out res);
            bool isIntTwo = Int32.TryParse(surNamEO, out res);
            bool isIntThree = Int32.TryParse(parTO, out res);
            bool isIntFour = Int32.TryParse(phoneNumbeRO, out res);
            bool isIntFive = Int32.TryParse(addresSO, out res);
            if (namEO.Length < 4 || isInt == true)
            {
                nameO.ToolTip = "это поле введено не корректно";
                nameO.Background = Brushes.Red;

            }
            else if (surNamEO.Length < 4 || isIntTwo == true)
            {
                surNameO.ToolTip = "это поле введено не корректно";
                surNameO.Background = Brushes.Red;
            }
            else if (parTO.Length < 4 || isIntThree == true)
            {
                partO.ToolTip = "это поле введено не корректно";
                partO.Background = Brushes.Red;
            }
            else if (phoneNumbeRO.Length != 9 || isIntFour == false)
            {
                phoneNumberO.ToolTip = "это поле введено не корректно";
                phoneNumberO.Background = Brushes.Red;
            }
            else if (addresSO.Length < 4 || isIntFive == true)
            {
                addresO.ToolTip = "это поле введено не корректно";
                addresO.Background = Brushes.Red;
            }




            else this.DialogResult = true;
        }
        private void buttonOutCust(object sender, RoutedEventArgs e)
        {
            MenegerCustomer MenegerCustomerAt = new MenegerCustomer();
            MenegerCustomerAt.Show();
            Hide();
        }

    }
}
