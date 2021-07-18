using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
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
    /// Логика взаимодействия для MenWith.xaml
    /// </summary>
    public partial class MenWith : Window
    {
        AppCont db;
        private List<Wreath> list;
        public MenWith()
        {
            InitializeComponent();
            db = new AppCont();
            db.Wreaths.Load();
            this.DataContext = db.Wreaths.Local.ToBindingList();
            list = db.Wreaths.ToList();
            Grid.ItemsSource = list;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Wreaths.ToList();
            MenWithAdd MenWithAddAT = new MenWithAdd(new Wreath());
            if (MenWithAddAT.ShowDialog() == true)
            {
                Wreath WreathaT = MenWithAddAT.WreathA;
                db.Wreaths.Add(WreathaT);
                list.Add(WreathaT);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Wreath WreathaT = Grid.SelectedItem as Wreath;
            if (WreathaT == null) return;
            MenWithAdd MenWithAddAT = new MenWithAdd(new Wreath
            {
                idWreath = WreathaT.idWreath,
                //solid = WreathaT.solid,
                classWre = WreathaT.classWre,
                typeWrea = WreathaT.typeWrea,
                typeV = WreathaT.typeV,
            });

            if (MenWithAddAT.ShowDialog() == true)
            {

                WreathaT = db.Wreaths.Find(MenWithAddAT.WreathA.idWreath);
                if (WreathaT != null)
                {
                    //WreathaT.solid = MenWithAddAT.WreathA.solid;
                    WreathaT.classWre = MenWithAddAT.WreathA.classWre;
                    WreathaT.typeWrea = MenWithAddAT.WreathA.typeWrea;
                    WreathaT.typeV= MenWithAddAT.WreathA.typeV;
                    db.Entry(WreathaT).State = EntityState.Modified;
                    list = db.Wreaths.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Wreaths.ToList();
            if (Grid.SelectedItem == null) return;
            // получаем выделенный объект
            Wreath WreathaT = Grid.SelectedItem as Wreath;
            if (WreathaT == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(WreathaT);
                db.Wreaths.Remove(WreathaT);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void button(object sender, RoutedEventArgs e)
        {
            SellMainForm ManegerRitGodsa = new SellMainForm();
            ManegerRitGodsa.Show();
            Hide();
        }
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (Grid.SelectedItem == null) return;
            string Temp = default;
            Wreath WreathaT = Grid.SelectedItem as Wreath;
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true) Temp = openFileDialog.FileName;
            WreathaT.imageCh = Temp;
            db.Entry(WreathaT).State = EntityState.Modified;
            list = db.Wreaths.ToList();
            Grid.ItemsSource = list;
            db.SaveChanges();
                 
        }

        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
                (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].solid.ToString() == Search.Text || /*Search.Text == list[i].skladKol.ToString()||*/
                    Search.Text.ToLower() == list[i].typeWrea.ToLower() || Search.Text.ToLower() == list[i].classWre.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }

        private void ImageDataGrid(object sender, RoutedEventArgs e)
        {
            // list = db.Wreaths.ToList();

        }
    }
}
