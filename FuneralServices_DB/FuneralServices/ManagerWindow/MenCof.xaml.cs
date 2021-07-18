using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для MenCof.xaml
    /// </summary>
    public partial class MenCof : Window
    {
        AppCont db;
        private List<Coffin> list;
        public MenCof()
        {
            InitializeComponent();
            db = new AppCont();
            db.Coffins.Load();
            this.DataContext = db.Coffins.Local.ToBindingList();
            list = db.Coffins.ToList();
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
        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (Grid.SelectedItem == null) return;
            string Temp = default;
            Coffin CoffinAr = Grid.SelectedItem as Coffin;
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            
            if (openFileDialog.ShowDialog() == true) 
            Temp = openFileDialog.FileName;
            if (Temp == null) return;
            if (CoffinAr == null) return;
            CoffinAr.imageCoffin = Temp;
            db.Entry(CoffinAr).State = EntityState.Modified;
            list = db.Coffins.ToList();
            Grid.ItemsSource = list;
            db.SaveChanges();

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Coffins.ToList();
            MenCofAdd MenCofAddat = new MenCofAdd(new Coffin());
            if (MenCofAddat.ShowDialog() == true)
            {
                Coffin Crosseae = MenCofAddat.CoffinA;
                db.Coffins.Add(Crosseae);
                list.Add(Crosseae);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Coffin CoffinAt = Grid.SelectedItem as Coffin;
            if (CoffinAt == null) return;
            MenCofAdd MenCrosAddA = new MenCofAdd(new Coffin
            {
                idCoffin = CoffinAt.idCoffin,
                //solidCof = CoffinAt.solidCof,
                classCof = CoffinAt.classCof,
                materCof = CoffinAt.materCof,
                countSk = CoffinAt.countSk,

            });

            if (MenCrosAddA.ShowDialog() == true)
            {

                CoffinAt = db.Coffins.Find(MenCrosAddA.CoffinA.idCoffin);
                if (CoffinAt != null)
                {
                    //CoffinAt.solidCof = MenCrosAddA.CoffinA.solidCof;
                    CoffinAt.classCof = MenCrosAddA.CoffinA.classCof;
                    CoffinAt.materCof = MenCrosAddA.CoffinA.materCof;
                    CoffinAt.countSk = MenCrosAddA.CoffinA.countSk;
                    db.Entry(CoffinAt).State = EntityState.Modified;
                    list = db.Coffins.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Coffins.ToList();
            if (Grid.SelectedItem == null) return;

            Coffin CoffinA = Grid.SelectedItem as Coffin;
            if (CoffinA == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(CoffinA);
                db.Coffins.Remove(CoffinA);
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
                if (list[i].classCof.ToLower() == Search.Text.ToLower() 
                    || Search.Text == list[i].countSk.ToString() || 
                    Search.Text == list[i].solidCof.ToString() || Search.Text.ToLower() == list[i].materCof.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
