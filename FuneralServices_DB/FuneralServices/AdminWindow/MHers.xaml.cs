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
    /// Логика взаимодействия для MHers.xaml
    /// </summary>
    /// 
   
    public partial class MHers : Window
    {
        AppCont db;
        private List<Hearse> list;
        public MHers()
        {
            InitializeComponent();
            db = new AppCont();
            db.Hearses.Load();
            this.DataContext = db.Hearses.Local.ToBindingList();
            list = db.Hearses.ToList();
            Grid.ItemsSource = list;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Hearses.ToList();
            MhersAdd MhersAddAt = new MhersAdd(new Hearse());
            if (MhersAddAt.ShowDialog() == true)
            {
                Hearse HearseAt = MhersAddAt.hearseA;
                db.Hearses.Add(HearseAt);
                list.Add(HearseAt);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Hearse HearseAt = Grid.SelectedItem as Hearse;
            if (HearseAt == null) return;
            MhersAdd MhersAddAt = new MhersAdd(new Hearse
            {
                idHearse = HearseAt.idHearse,
                //solidHe = HearseAt.solidHe,
                brand = HearseAt.brand,
            });

            if (MhersAddAt.ShowDialog() == true)
            {

                HearseAt = db.Hearses.Find(MhersAddAt.hearseA.idHearse);
                if (MhersAddAt != null)
                {
                    //HearseAt.solidHe = MhersAddAt.hearseA.solidHe;
                    HearseAt.brand = MhersAddAt.hearseA.brand;
                    db.Entry(HearseAt).State = EntityState.Modified;
                    list = db.Hearses.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Hearses.ToList();
            if (Grid.SelectedItem == null) return;
            // получаем выделенный объект
            Hearse HearseAt = Grid.SelectedItem as Hearse;
            if (HearseAt == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(HearseAt);
                db.Hearses.Remove(HearseAt);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void button(object sender, RoutedEventArgs e)
        {
            MenegerFunrServic MenegerFunrServicaT = new MenegerFunrServic();
            MenegerFunrServicaT.Show();
            Hide();
        }

        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
                (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].brand.ToLower() == Search.Text.ToLower() || Search.Text == list[i].solidHe.ToString() )
                    {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
