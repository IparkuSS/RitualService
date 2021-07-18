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
    /// Логика взаимодействия для MenWork.xaml
    /// </summary>
    public partial class MenWork : Window
    {
        AppCont db;
        private List<Worker> list;
        public MenWork()
        {
            InitializeComponent();

            db = new AppCont();
            db.Workers.Load();
            this.DataContext = db.Workers.Local.ToBindingList();
            list = db.Workers.ToList();
            Grid.ItemsSource = list;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            list = db.Workers.ToList();
            MenWorkAdd MenWithAddAT = new MenWorkAdd(new Worker());
            if (MenWithAddAT.ShowDialog() == true)
            {
                Worker WreathaT = MenWithAddAT.WorkerA;
                db.Workers.Add(WreathaT);
                list.Add(WreathaT);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if (Grid.SelectedItem == null) return;

            Worker WreathaT = Grid.SelectedItem as Worker;
            if (WreathaT == null) return;
            MenWorkAdd MenWithAddAT = new MenWorkAdd(new Worker
            {
                idWorker = WreathaT.idWorker,
                surNameWorker = WreathaT.surNameWorker,
                nameWorker = WreathaT.nameWorker,
                numberTelWorker = WreathaT.numberTelWorker,
                partWorker = WreathaT.partWorker
            });

            if (MenWithAddAT.ShowDialog() == true)
            {

                WreathaT = db.Workers.Find(MenWithAddAT.WorkerA.idWorker);
                if (WreathaT != null)
                {
                    WreathaT.surNameWorker = MenWithAddAT.WorkerA.surNameWorker;
                    WreathaT.nameWorker = MenWithAddAT.WorkerA.nameWorker;
                    WreathaT.numberTelWorker = MenWithAddAT.WorkerA.numberTelWorker;
                    WreathaT.partWorker = MenWithAddAT.WorkerA.partWorker;
                    db.Entry(WreathaT).State = EntityState.Modified;
                    list = db.Workers.ToList();
                    Grid.ItemsSource = list;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            list = db.Workers.ToList();
            if (Grid.SelectedItem == null) return;
            // получаем выделенный объект
            Worker WreathaT = Grid.SelectedItem as Worker;
            if (WreathaT == null) return;
            MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись?", "Проверка", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
            {
                list.Remove(WreathaT);
                db.Workers.Remove(WreathaT);
                Grid.ItemsSource = list;
                db.SaveChanges();
            }
        }

        private void button(object sender, RoutedEventArgs e)
        {
            MenegerFunrServic MenWithA = new MenegerFunrServic();
            MenWithA.Show();
            Hide();
        }

        private void Faind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
                (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = null;
            bool flag = true;
            for (int i = 0; i < list.Count; i++)
                if (list[i].nameWorker.ToLower() == Search.Text.ToLower() 
                    || Search.Text == list[i].numberTelWorker|| Search.Text.ToLower() == list[i].partWorker.ToLower()
                    || Search.Text.ToLower() == list[i].surNameWorker.ToLower())
                {
                    (Grid.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Green;
                    flag = false;

                }
            if (flag == true) MessageBox.Show("Не найдено");

            Search.Text = null;
        }
    }
}
