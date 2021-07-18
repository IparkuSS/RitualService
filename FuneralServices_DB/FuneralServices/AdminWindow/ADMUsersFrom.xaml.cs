using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для ADMUsersFrom.xaml
    /// </summary>
    public partial class ADMUsersFrom : Window
    {
        AppCont db;
        private List<user> list;
        public ADMUsersFrom()
        {
            InitializeComponent();
            db = new AppCont();
            db.Crosses.Load();
            this.DataContext = db.Crosses.Local.ToBindingList();
            list = db.users.ToList();
            Grid.ItemsSource = list;
        }

        private void button(object sender, RoutedEventArgs e)
        {
            AdmMainForm ManegerRitGodsa = new AdmMainForm();
            ManegerRitGodsa.Show();
            Hide();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.users.ToList();
            if (Grid.SelectedItem == null) return;

            user CrosseA = Grid.SelectedItem as user;
            if (CrosseA == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(CrosseA);
                db.users.Remove(CrosseA);
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
                if (list[i].login.ToLower() == Search.Text.ToLower() || Search.Text.ToLower() == list[i].name.ToLower() 
                    || Search.Text.ToLower() == list[i].role.ToLower() || Search.Text.ToLower() == list[i].surName.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
