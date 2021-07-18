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
    /// Логика взаимодействия для ManegerRitGods.xaml
    /// </summary>
    public partial class ManegerRitGods : Window
    {
        //AppCont db;
        //private List<RitualGod> list;

        public ManegerRitGods()
        {
            InitializeComponent();
            //db = new AppCont();
            //db.RitualGods.Load();
            //this.DataContext = db.RitualGods.Local.ToBindingList();
            //list = db.RitualGods.ToList();
            //Grid.ItemsSource = list;
        }
        //private void Window_Loaded(object sender, RoutedEventArgs e) { }
        //private void Add_Click(object sender, RoutedEventArgs e)
        //{
        //    list = db.RitualGods.ToList();
        //    MenegerRitGodsAdd MenegerRitGodsAddAt = new MenegerRitGodsAdd(new RitualGod());
        //    if (MenegerRitGodsAddAt.ShowDialog() == true)
        //    {
        //        RitualGod RitualGodAt = MenegerRitGodsAddAt.ritualGod;
        //        db.RitualGods.Add(RitualGodAt);
        //        list.Add(RitualGodAt);
        //        Grid.ItemsSource = list;
        //        db.SaveChanges();
        //    }
        //}
        //private void Edit_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Grid.SelectedItem == null) return;
        //    RitualGod RitualGodAt = Grid.SelectedItem as RitualGod;

        //    MenegerRitGodsAdd MenegerRitGodsAddAt = new MenegerRitGodsAdd(new RitualGod
        //    {
        //        idRitualGod = RitualGodAt.idRitualGod,
        //        wreath = RitualGodAt.wreath,
        //        coffin = RitualGodAt.coffin,
        //        cross = RitualGodAt.cross
        //    });

        //    if (MenegerRitGodsAddAt.ShowDialog() == true)
        //    {
        //        RitualGodAt = db.RitualGods.Find(MenegerRitGodsAddAt.ritualGod.idRitualGod);
        //        if (RitualGodAt != null)
        //        {
        //            RitualGodAt.wreath = MenegerRitGodsAddAt.ritualGod.wreath;
        //            RitualGodAt.coffin = MenegerRitGodsAddAt.ritualGod.coffin;
        //            RitualGodAt.cross = MenegerRitGodsAddAt.ritualGod.cross;
        //            db.Entry(RitualGodAt).State = EntityState.Modified;
        //            list = db.RitualGods.ToList();
        //            Grid.ItemsSource = list;
        //            db.SaveChanges();
        //        }
        //    }
        //}
        //private void Delete_Click(object sender, RoutedEventArgs e)
        //{
        //    list = db.RitualGods.ToList();
        //    if (Grid.SelectedItem == null) return;

        //    RitualGod ritualGod = Grid.SelectedItem as RitualGod;
        //    list.Remove(ritualGod);
        //    db.RitualGods.Remove(ritualGod);
        //    Grid.ItemsSource = list;
        //    db.SaveChanges();
        //}
        private void MenMaFoOut(object sender, RoutedEventArgs e)
        {
            MenegMainForm MenegMainFormAt = new MenegMainForm();
            MenegMainFormAt.Show();
            Hide();
        }

        private void ButCros(object sender, RoutedEventArgs e)
        {

            MenCros MenCrosAt = new MenCros();
            MenCrosAt.Show();
            Hide();

        }

        private void Butw(object sender, RoutedEventArgs e)
        {
            MenWith MenWithA = new MenWith();
            MenWithA.Show();
            Hide();
        }

        private void ButCOF(object sender, RoutedEventArgs e)
        {
            MenCof MenCofA = new MenCof();
            MenCofA.Show();
            Hide();
        }
    }
}
