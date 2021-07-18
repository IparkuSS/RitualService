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
    /// Логика взаимодействия для MenMonumentForm.xaml
    /// </summary>
    public partial class MenMonumentForm : Window
    {
        AppCont db;
        private List<Monument> list;
        public MenMonumentForm()
        {
            InitializeComponent();
            db = new AppCont();
            db.Monuments.Load();
            this.DataContext = db.Monuments.Local.ToBindingList();
            list = db.Monuments.ToList();
            Grid.ItemsSource = list;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Monuments.ToList();
            MenMonumAdd MenMonumAddAt = new MenMonumAdd(new Monument());
            if (MenMonumAddAt.ShowDialog() == true)
            {
                Monument MonumentAt = MenMonumAddAt.monumentAt;
                db.Monuments.Add(MonumentAt);
                list.Add(MonumentAt);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Monument MonumentAt = Grid.SelectedItem as Monument;
            if (MonumentAt == null) return;
            MenMonumAdd MenMonumAddAt = new MenMonumAdd(new Monument
            {
                idMonument = MonumentAt.idMonument,
                orgMon = MonumentAt.orgMon,
                numPhon = MonumentAt.numPhon,
                //solidMon = MonumentAt.solidMon,
            });

            if (MenMonumAddAt.ShowDialog() == true)
            {

                MonumentAt = db.Monuments.Find(MenMonumAddAt.monumentAt.idMonument);
                if (MonumentAt != null)
                {
                    MonumentAt.orgMon = MenMonumAddAt.monumentAt.orgMon;
                    MonumentAt.numPhon = MenMonumAddAt.monumentAt.numPhon;
                    //MonumentAt.solidMon = MenMonumAddAt.monumentAt.solidMon;
                    db.Entry(MonumentAt).State = EntityState.Modified;
                    list = db.Monuments.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Monuments.ToList();
            if (Grid.SelectedItem == null) return;
            // получаем выделенный объект
            Monument MonumentAt = Grid.SelectedItem as Monument;
            if (MonumentAt == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(MonumentAt);
                db.Monuments.Remove(MonumentAt);
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
                if (list[i].numPhon.ToLower() == Search.Text.ToLower() 
                    || Search.Text == list[i].solidMon.ToString() || Search.Text.ToLower() == list[i].orgMon.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
