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
    /// Логика взаимодействия для MtheFun.xaml
    /// </summary>
    public partial class MtheFun : Window
    {
        AppCont db;
        private List<TheFuneral> list;
        public MtheFun()
        {
            InitializeComponent();

            db = new AppCont();
            db.TheFunerals.Load();
            this.DataContext = db.TheFunerals.Local.ToBindingList();
            list = db.TheFunerals.ToList();
            Grid.ItemsSource = list;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.TheFunerals.ToList();
            MtheFunAdd MtheFunAddAt = new MtheFunAdd(new TheFuneral());
            if (MtheFunAddAt.ShowDialog() == true)
            {
                TheFuneral TheFuneralAt = MtheFunAddAt.TheFuneralA;
                db.TheFunerals.Add(TheFuneralAt);
                list.Add(TheFuneralAt);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            TheFuneral TheFuneralAt = Grid.SelectedItem as TheFuneral;
            if (TheFuneralAt == null) return;
            MtheFunAdd MtheFunAddAtAt = new MtheFunAdd(new TheFuneral
            {
                idTheFuneral = TheFuneralAt.idTheFuneral,
                organiz = TheFuneralAt.organiz,

                numPhon = TheFuneralAt.numPhon,
                //solidFunr = TheFuneralAt.solidFunr,
            });

            if (MtheFunAddAtAt.ShowDialog() == true)
            {

                TheFuneralAt = db.TheFunerals.Find(MtheFunAddAtAt.TheFuneralA.idTheFuneral);
                if (TheFuneralAt != null)
                {
                    TheFuneralAt.organiz = MtheFunAddAtAt.TheFuneralA.organiz;
                    TheFuneralAt.numPhon = MtheFunAddAtAt.TheFuneralA.numPhon;
                    //TheFuneralAt.solidFunr = MtheFunAddAtAt.TheFuneralA.solidFunr;
                    db.Entry(TheFuneralAt).State = EntityState.Modified;
                    list = db.TheFunerals.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.TheFunerals.ToList();
            if (Grid.SelectedItem == null) return;
           
            TheFuneral TheFuneralsa = Grid.SelectedItem as TheFuneral;
            if (TheFuneralsa == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(TheFuneralsa);
                db.TheFunerals.Remove(TheFuneralsa);
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
                if (list[i].numPhon.ToLower() == Search.Text.ToLower() ||
                    Search.Text == list[i].solidFunr.ToString() || list[i].organiz.ToLower() == Search.Text.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
