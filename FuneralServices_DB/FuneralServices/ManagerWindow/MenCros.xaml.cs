using Microsoft.Win32;
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
    /// Логика взаимодействия для MenCros.xaml
    /// </summary>
    public partial class MenCros : Window
    {
        AppCont db;
        private List<Crosse> list;
        public MenCros()
        {
            InitializeComponent();
            db = new AppCont();
            db.Crosses.Load();
            this.DataContext = db.Crosses.Local.ToBindingList();
            list = db.Crosses.ToList();
            Grid.ItemsSource = list;

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void button(object sender, RoutedEventArgs e)
        {
            SellMainForm ManegerRitGodsa = new SellMainForm();
            ManegerRitGodsa.Show();
            Hide();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Crosses.ToList();
            MenCrosAdd MenCrosAddat = new MenCrosAdd(new Crosse());
            if (MenCrosAddat.ShowDialog() == true)
            {
                Crosse Crosseae = MenCrosAddat.CrosseA;
                db.Crosses.Add(Crosseae);
                list.Add(Crosseae);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Crosse CrosseAt = Grid.SelectedItem as Crosse;
            if (CrosseAt == null) return;
            MenCrosAdd MenCrosAddA = new MenCrosAdd(new Crosse
            {
                idCrossed = CrosseAt.idCrossed,
                //solidCros = CrosseAt.solidCros,
                classCros = CrosseAt.classCros,
                typeCros = CrosseAt.typeCros,
                countSkCr = CrosseAt.countSkCr,
            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                CrosseAt = db.Crosses.Find(MenCrosAddA.CrosseA.idCrossed);
                if (CrosseAt != null)
                {
                    //CrosseAt.solidCros = MenCrosAddA.CrosseA.solidCros;
                    CrosseAt.classCros = MenCrosAddA.CrosseA.classCros;
                    CrosseAt.typeCros = MenCrosAddA.CrosseA.typeCros;
                    CrosseAt.countSkCr = MenCrosAddA.CrosseA.countSkCr;
                    db.Entry(CrosseAt).State = EntityState.Modified;
                    list = db.Crosses.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (Grid.SelectedItem == null) return;
            string Temp = default;
            Crosse CrosseaT = Grid.SelectedItem as Crosse;
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true) Temp = openFileDialog.FileName;
            CrosseaT.imageCrosses = Temp;
            db.Entry(CrosseaT).State = EntityState.Modified;
            list = db.Crosses.ToList();
            Grid.ItemsSource = list;
            db.SaveChanges();

        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Crosses.ToList();
            if (Grid.SelectedItem == null) return;

            Crosse CrosseA = Grid.SelectedItem as Crosse;
            if (CrosseA == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(CrosseA);
                db.Crosses.Remove(CrosseA);
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
                if (list[i].typeCros.ToLower() == Search.Text.ToLower() 
                    || Search.Text == list[i].countSkCr.ToString() 
                    || Search.Text == list[i].solidCros.ToString() || Search.Text.ToLower() == list[i].classCros.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
