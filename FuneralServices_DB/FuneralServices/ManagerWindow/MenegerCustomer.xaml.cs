using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FuneralServices
{
    /// <summary>
    /// Логика взаимодействия для MenegerCustomer.xaml
    /// </summary>
    public partial class MenegerCustomer : Window
    {
        AppCont db;
        private List<Customer> list;
        public MenegerCustomer()
        {

            InitializeComponent();
            db = new AppCont();
            db.Customers.Load();
            this.DataContext = db.Customers.Local.ToBindingList();
            list = db.Customers.ToList();
            Grid.ItemsSource = list;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void button(object sender, RoutedEventArgs e)
        {
            MenegMainForm MenegMainFormAt = new MenegMainForm();
            MenegMainFormAt.Show();
            Hide();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Customers.ToList();
            MenegerCustomerAdd MenegerCustomerAddAt = new MenegerCustomerAdd(new Customer());
            if (MenegerCustomerAddAt.ShowDialog() == true)
            {
                Customer Customerat = MenegerCustomerAddAt.Customer;
                db.Customers.Add(Customerat);
                list.Add(Customerat);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Customer customer = Grid.SelectedItem as Customer;
            if (customer == null) return;
            MenegerCustomerAdd MenegerCustomerAddAt = new MenegerCustomerAdd(new Customer
            {
                idCustomer = customer.idCustomer,
                name = customer.name,
                surName = customer.surName,
                part = customer.part,
                phoneNumber = customer.phoneNumber,
                addres = customer.addres

            });

            if (MenegerCustomerAddAt.ShowDialog() == true)
            {

                customer = db.Customers.Find(MenegerCustomerAddAt.Customer.idCustomer);
                if (customer != null)
                {
                    customer.name = MenegerCustomerAddAt.Customer.name;
                    customer.surName = MenegerCustomerAddAt.Customer.surName;
                    customer.part = MenegerCustomerAddAt.Customer.part;
                    customer.phoneNumber = MenegerCustomerAddAt.Customer.phoneNumber;
                    customer.addres = MenegerCustomerAddAt.Customer.addres;
                    db.Entry(customer).State = EntityState.Modified;
                    list = db.Customers.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Customers.ToList();
            if (Grid.SelectedItem == null) return;

            Customer customer = Grid.SelectedItem as Customer;
            if (customer == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(customer);
                db.Customers.Remove(customer);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
                (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].addres.ToLower() == Search.Text.ToLower() 
                    || Search.Text.ToLower() == list[i].name.ToLower() || Search.Text.ToLower() == list[i].part.ToLower() 
                    || Search.Text.ToLower() == list[i].surName.ToLower()
                    || Search.Text.ToLower() == list[i].phoneNumber.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
